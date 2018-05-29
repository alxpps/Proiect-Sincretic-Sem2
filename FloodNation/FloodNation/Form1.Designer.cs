namespace FloodNation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.lbl_connect = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_send_msg = new System.Windows.Forms.Button();
            this.textBox_send_msg = new System.Windows.Forms.TextBox();
            this.btn_led_on = new System.Windows.Forms.Button();
            this.btn_led_off = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_temp = new System.Windows.Forms.Label();
            this.lbl_inundatie = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(419, 12);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(524, 12);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_disconnect.TabIndex = 1;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // lbl_connect
            // 
            this.lbl_connect.AutoSize = true;
            this.lbl_connect.Location = new System.Drawing.Point(651, 22);
            this.lbl_connect.Name = "lbl_connect";
            this.lbl_connect.Size = new System.Drawing.Size(35, 13);
            this.lbl_connect.TabIndex = 2;
            this.lbl_connect.Text = "label1";
            // 
            // btn_send_msg
            // 
            this.btn_send_msg.Location = new System.Drawing.Point(6, 35);
            this.btn_send_msg.Name = "btn_send_msg";
            this.btn_send_msg.Size = new System.Drawing.Size(75, 23);
            this.btn_send_msg.TabIndex = 3;
            this.btn_send_msg.Text = "Send";
            this.btn_send_msg.UseVisualStyleBackColor = true;
            this.btn_send_msg.Click += new System.EventHandler(this.btn_send_msg_Click);
            // 
            // textBox_send_msg
            // 
            this.textBox_send_msg.Location = new System.Drawing.Point(107, 38);
            this.textBox_send_msg.Name = "textBox_send_msg";
            this.textBox_send_msg.Size = new System.Drawing.Size(340, 20);
            this.textBox_send_msg.TabIndex = 4;
            // 
            // btn_led_on
            // 
            this.btn_led_on.Location = new System.Drawing.Point(106, 51);
            this.btn_led_on.Name = "btn_led_on";
            this.btn_led_on.Size = new System.Drawing.Size(75, 23);
            this.btn_led_on.TabIndex = 5;
            this.btn_led_on.Text = "On";
            this.btn_led_on.UseVisualStyleBackColor = true;
            this.btn_led_on.Click += new System.EventHandler(this.btn_led_on_Click);
            // 
            // btn_led_off
            // 
            this.btn_led_off.Location = new System.Drawing.Point(212, 51);
            this.btn_led_off.Name = "btn_led_off";
            this.btn_led_off.Size = new System.Drawing.Size(75, 23);
            this.btn_led_off.TabIndex = 6;
            this.btn_led_off.Text = "Off";
            this.btn_led_off.UseVisualStyleBackColor = true;
            this.btn_led_off.Click += new System.EventHandler(this.btn_led_off_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Aprindere led";
            // 
            // lbl_temp
            // 
            this.lbl_temp.AutoSize = true;
            this.lbl_temp.Location = new System.Drawing.Point(127, 36);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(35, 13);
            this.lbl_temp.TabIndex = 8;
            this.lbl_temp.Text = "label2";
            // 
            // lbl_inundatie
            // 
            this.lbl_inundatie.AutoSize = true;
            this.lbl_inundatie.Location = new System.Drawing.Point(127, 76);
            this.lbl_inundatie.Name = "lbl_inundatie";
            this.lbl_inundatie.Size = new System.Drawing.Size(35, 13);
            this.lbl_inundatie.TabIndex = 9;
            this.lbl_inundatie.Text = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_send_msg);
            this.groupBox1.Controls.Add(this.textBox_send_msg);
            this.groupBox1.Location = new System.Drawing.Point(29, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_led_on);
            this.groupBox2.Controls.Add(this.btn_led_off);
            this.groupBox2.Location = new System.Drawing.Point(35, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 131);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Led";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lbl_temp);
            this.groupBox3.Controls.Add(this.lbl_inundatie);
            this.groupBox3.Location = new System.Drawing.Point(399, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 131);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reciveing Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Temperatura:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(247, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data ultimei inundatii";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 357);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_connect);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Label lbl_connect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_send_msg;
        private System.Windows.Forms.TextBox textBox_send_msg;
        private System.Windows.Forms.Button btn_led_on;
        private System.Windows.Forms.Button btn_led_off;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_temp;
        private System.Windows.Forms.Label lbl_inundatie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

