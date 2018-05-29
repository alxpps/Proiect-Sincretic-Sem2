#include <EEPROM.h>
#include <MenuBackend.h>
#include <LiquidCrystal.h>
LiquidCrystal lcd(8, 9, 4, 5, 6, 7);

String inputString = "";    
boolean stringComplete = false;   
String commandString = "";
float tmp;
const int right=60;
const int upp=160;
const int downn=360;
const int left=520;
const int sel=800;

const int trigPin = 2;
const int echoPin = 3;
long duration;
int distance;

const int led = A1;

int nrInundatiiMem = 0;
int nrMesajeMem = 0;

byte buttonState = 0;

void menuUseEvent(MenuUseEvent used);
void menuChangeEvent(MenuChangeEvent changed);


MenuBackend menu = MenuBackend(menuUseEvent, menuChangeEvent);
  
  MenuItem Mesaje = MenuItem("Mesaje");
  MenuItem Control = MenuItem("Control");
  MenuItem Temperatura = MenuItem("Temperatura");
  MenuItem Inundatii = MenuItem("Inundatii");

  MenuItem Necitite = MenuItem("Necitite");
  MenuItem Citite = MenuItem("Citite");
  MenuItem Stergere = MenuItem("Sterge");
  MenuItem Manual = MenuItem("Manual");
  MenuItem Automat = MenuItem("Automat");
  MenuItem TempCurenta = MenuItem("Temp Curenta");

  MenuItem inund1 = MenuItem("Inundatia 1");
  MenuItem inund2 = MenuItem("Inundatia 2");
  MenuItem inund3 = MenuItem("Inundatia 3");
  MenuItem inund4 = MenuItem("Inundatia 4");
  MenuItem inund5 = MenuItem("Inundatia 5");
  MenuItem inund6 = MenuItem("Inundatia 6");
  MenuItem inund7 = MenuItem("Inundatia 7");
  MenuItem inund8 = MenuItem("Inundatia 8");
  MenuItem inund9 = MenuItem("Inundatia 9");
  MenuItem inund10 = MenuItem("Inundatia 10");

  MenuItem Necitit1 = MenuItem("Mesaj necitit 1");
  MenuItem Necitit2 = MenuItem("Mesaj necitit 2");
  MenuItem Necitit3 = MenuItem("Mesaj necitit 3");
  MenuItem Necitit4 = MenuItem("Mesaj necitit 4");
  MenuItem Necitit5 = MenuItem("Mesaj necitit 5");
  MenuItem Necitit6 = MenuItem("Mesaj necitit 6");
  MenuItem Necitit7 = MenuItem("Mesaj necitit 7");
  MenuItem Necitit8 = MenuItem("Mesaj necitit 8");
  MenuItem Necitit9 = MenuItem("Mesaj necitit 9");
  MenuItem Necitit10 = MenuItem("Mesaj necitit 10");   
   
  MenuItem Citit1 = MenuItem("Mesaj citit 1");
  MenuItem Citit2 = MenuItem("Mesaj citit 2");
  MenuItem Citit3 = MenuItem("Mesaj citit 3");
  MenuItem Citit4 = MenuItem("Mesaj citit 4");
  MenuItem Citit5 = MenuItem("Mesaj citit 5");
  MenuItem Citit6 = MenuItem("Mesaj citit 6");
  MenuItem Citit7 = MenuItem("Mesaj citit 7");
  MenuItem Citit8 = MenuItem("Mesaj citit 8");
  MenuItem Citit9 = MenuItem("Mesaj citit 9");
  MenuItem Citit10 = MenuItem("Mesaj citit 10");
  
  MenuItem Confirmati = MenuItem("Confirmare stergere");
  

void menuSetup() {
  menu.getRoot().add(Mesaje).add(Control).add(Temperatura).add(Inundatii);
    Mesaje.addRight(Necitite).add(Citite).add(Stergere);
    Necitite.addRight(Necitit1).add(Necitit2).add(Necitit3).add(Necitit4).add(Necitit5).add(Necitit6).add(Necitit7).add(Necitit8).add(Necitit9).add(Necitit10);
    Citite.addRight(Citit1).add(Citit2).add(Citit3).add(Citit4).add(Citit5).add(Citit6).add(Citit7).add(Citit8).add(Citit9).add(Citit10);
    Stergere.addRight(Confirmati);

    Control.addRight(Manual).add(Automat);

    Temperatura.addRight(TempCurenta);

    Inundatii.addRight(inund1).add(inund2).add(inund3).add(inund4).add(inund5).add(inund6).add(inund7).add(inund8).add(inund9).add(inund10);
}

int Temp() {
  float temp=analogRead(A5);
  temp = temp*0.48828125;
  return temp;
}

void menuUseEvent(MenuUseEvent used)
{
  String usedMenuName = used.item.getName();

  if(usedMenuName == "Temp Curenta"){
    lcd.clear();
    lcd.print("Temp:");
    lcd.print(Temp());
    lcd.print(" 'C");    
  }
  if(usedMenuName == "Confirmare stergere"){
     for(int addr=0; addr <= EEPROM.length(); addr++)
         EEPROM.write(addr,0);
  }
  
}

void menuChangeEvent(MenuChangeEvent changed)
{
  String changedMenuName = changed.to.getName();
  lcd.clear();
  lcd.print(changedMenuName);

  if(changedMenuName.indexOf("Inundatia") == 0)
    listIND(changedMenuName);

  if(changedMenuName.indexOf("Mesaj necitit") == 0)
    listMSG(changedMenuName);
    
}

byte readButtons() 
{  
    if(analogRead(A0) <right)
      return 'r';
    else if(analogRead(A0) <upp)
      return 'u';
    else if(analogRead(A0) <downn)
      return 'd';
    else if(analogRead(A0) <left)
      return 'l';
      if(analogRead(A0) <sel)
    return 'e';

    return 0;
}

void checkBtn(){
  buttonState = readButtons();
    switch (buttonState) {
      case 'u': menu.moveUp(); break;
      case 'd': menu.moveDown(); break;
      case 'r': menu.moveRight(); break;
      case 'l': menu.moveLeft(); break;
      case 'e': menu.use(); break;  
  }
}

void checkDist() {
    digitalWrite(trigPin, LOW);
    delay(20);
    digitalWrite(trigPin, HIGH);
    delay(100);
    digitalWrite(trigPin, LOW);
    duration = pulseIn(echoPin, HIGH);
    distance= duration/29.1/2;
    

  if((distance>3)&&(distance<5)){
   
    lcd.clear();
    lcd.print("Am adaugat inundatia");
    Serial.println("#F");
    
  }
  
  
}

void addIND(char data[]) {
  int startIndex = 200 + nrInundatiiMem * 15;
  int endIndex = startIndex +16;
 int i;
 
  for(int addr = startIndex; addr < endIndex; addr++){
    if(i < strlen(data)) {
      EEPROM.write(addr, data[i]);
    } else {
      EEPROM.write(addr, ' ');
    }
    i++;
  }
  nrInundatiiMem++;
  
 
}

void listIND(String numeIND) {
  lcd.clear();
  lcd.setCursor(0,0);
  lcd.print(numeIND);
 
  int startIndex =200+(numeIND.substring(10,12).toInt() -1) * 15;
  int endIndex = startIndex + 14;
  
  lcd.setCursor(0,1);
  
  for(int addr=startIndex; addr <= endIndex; addr++)
    if((char)EEPROM.read(addr) != ' ')
      lcd.print((char)EEPROM.read(addr));
}


void setup() {
  Serial.begin(9600);
  lcd.begin(16, 2);
  menuSetup();
  
  pinMode(13, INPUT);
  pinMode(led, OUTPUT);
  lcd.setCursor(0,0);
  lcd.print(Temp());
  lcd.print("'C");
  lcd.setCursor(0,1);
  lcd.print(nrMesajeMem);
  lcd.print(" Mesaje");

  pinMode(trigPin, OUTPUT); 
  pinMode(echoPin, INPUT);
   
  
 
}

void loop()
{
  checkBtn();
  checkDist();
  String lbl_temp, get_temp;
  get_temp=Temp();
  lbl_temp="#T" + get_temp;
 Serial.println(lbl_temp);
  
  if (stringComplete)
  {
    stringComplete = false;
    getCommand();
    if (commandString.equals("MESS"))
    {
      char msg[10];
      String text = getTextToPrint();
      text.toCharArray(msg,16);
      addMSG(msg);
      lcd.setCursor(0, 1);
      lcd.print(text);
    }
    if (commandString.equals("FLOD"))
    {
      char data[10];
      String text = getTextToPrint();
      text.toCharArray(data,16);
      addIND(data);
      lcd.setCursor(0, 1);
      lcd.print(text);
    }
    
    if(commandString.equals("LEDO"))
    {
    boolean LedState = getLedState();
    if(LedState == true)
    {
      digitalWrite(led,HIGH);
    }else
    {
      digitalWrite(led,LOW);
    }   
  }
    inputString = "";
    commandString = "";
  }
  

  delay(300);
}

void getCommand()
{
  if (inputString.length() > 0)
  {
    commandString = inputString.substring(1, 5);
  }
}

String getTextToPrint()
{
  String value = inputString.substring(5, inputString.length() - 2);
  return value +".";
}

void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    // add it to the inputString:
    inputString += inChar;
    // if the incoming character is a newline, set a flag
    // so the main loop can do something about it:
    if (inChar == '\n') {
      stringComplete = true;
    }
  }
}
boolean getLedState()
{
  boolean state = false;
  if(inputString.substring(4,6).equals("ON"))
  {
    state = true;
  }else
  {
    state = false;
  }
  return state;
}

void addMSG(char data[]) {
  int startIndex = nrMesajeMem * 15;
  int endIndex = startIndex +16;
  int i=0;
  
  for(int addr = startIndex; addr < endIndex; addr++){
    if(i < strlen(data)) {
      EEPROM.write(addr, data[i]);
    } else {
      EEPROM.write(addr, ' ');
    }
    i++;
  }
  nrMesajeMem++;
  lcd.clear();
  lcd.setCursor(0,0);
  lcd.print(nrMesajeMem);
  lcd.print(" New Msg");
 
}

void listMSG(String numeMesaj) {
  lcd.clear();
  lcd.setCursor(0,0);
  lcd.print(numeMesaj);
 
  int startIndex =(numeMesaj.substring(14,16).toInt() -1) * 15;
  int endIndex = startIndex + 14;
  
  lcd.setCursor(0,1);
  
  for(int addr=startIndex; addr <= endIndex; addr++)
    if((char)EEPROM.read(addr) != '.')
      lcd.print((char)EEPROM.read(addr));
}


