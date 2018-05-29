using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net;
using System.Net.Mail;

namespace FloodNation
{
    public partial class Form1 : Form
    {
        DateTime dateTime = DateTime.UtcNow.Date;
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        String txtStmp;
        String email1 = "alexandru.pps96@gmail.com";
        String email2 = "benibalintoni@gmail.com";
        String body = "Atentie, pericol de inundatie detectat la ora: " + DateTime.Now.ToString("h:mm:ss tt");
        String toEmail = "proiect.sincretic.sem2@gmail.com";
        String subject = "Inundatie!!!";
        public Form1()
        {
            InitializeComponent();
            lbl_connect.Text = "Disconected";
            btn_disconnect.Enabled = false;
            btn_led_off.Enabled = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            getAvailablePorts();
            serialPort1.DataReceived += serialPort1_DataReceived;
           
        }

        void getAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
        }
        public void serialConnect()
        {

            serialPort1.PortName = "COM3";
            serialPort1.BaudRate = 9600;
            serialPort1.Open();
            btn_connect.Enabled = false;
            btn_disconnect.Enabled = true;
           

            if (serialPort1.IsOpen)
            {
                lbl_connect.Text = "Connected";
                btn_disconnect.Enabled = true;
                btn_connect.Enabled = false;
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string line = serialPort1.ReadLine();
            this.BeginInvoke(new LineReceivedEvent(LineReceived), line);
        }

        private delegate void LineReceivedEvent(string line);
        private void LineReceived(string line)
        {
       
            if (line.Length > 0)
            {
                if (line.Length > 2)
                {
                    switch (line.Substring(0, 2))
                    {
                        case "#T": lbl_temp.Text = line.Substring(2); break;
                        case "#F": lbl_inundatie.Text = dateTime.ToString("dd/MM/yyyy");
                          serialPort1.Write("#FLOD" + dateTime.ToString("dd/MM/yyyy") + "#\n");
                            sendEmail();
                                break;

                    }
                }
            }
        }

        public void sendEmail()
        {
            txtStmp = "smtp.gmail.com";
            login = new NetworkCredential("proiect.sincretic.sem2@gmail.com", "proiectsincretic2");
            client = new SmtpClient("smtp.gmail.com", 587);
          //  client.Port = Convert.ToInt32("587");
            client.Credentials = login;
            msg = new MailMessage("proiect.sincretic.sem2@gmail.com", email2, subject, body);
          
            // msg.To.Add(new MailAddress(email2));
          //  msg.Subject ="Inundatie!!";
          //  msg.Body = body;
          //  msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.High;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.Credentials = login;
            client.EnableSsl = true;
            client.Send(msg);

           

           
            
        }

     

            public void serialDisconnect()
            {
                btn_connect.Enabled = true;
                btn_disconnect.Enabled = false;
                lbl_connect.Text = "Disconnected";
                serialPort1.Close();
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
            }
            private void btn_connect_Click(object sender, EventArgs e)
            {
                serialConnect();
            }

            private void btn_disconnect_Click(object sender, EventArgs e)
            {
                serialDisconnect();
            }

            private void btn_send_msg_Click(object sender, EventArgs e)
            {
                serialPort1.Write("#MESS" + textBox_send_msg.Text + "\n");
                textBox_send_msg.Clear();
            }

            private void btn_led_on_Click(object sender, EventArgs e)
            {
                serialPort1.Write("#LEDON\n");
                btn_led_off.Enabled = true;
                btn_led_on.Enabled = false;
            }

            private void btn_led_off_Click(object sender, EventArgs e)
            {
                serialPort1.Write("#LEDOF\n");
                btn_led_off.Enabled = false;
                btn_led_on.Enabled = true;
            }

      
    }
    } 
