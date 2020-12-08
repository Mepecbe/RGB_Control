#define RED_PIN   9
#define GREEN_PIN 11
#define BLUE_PIN  10
#define Switch_1 2
#define Switch_2 4
#define FotoRezistor A0

byte rgb[] = {0,0,0};

void setup() {
  // put your setup code here, to run once:
  pinMode(RED_PIN, OUTPUT);
  pinMode(GREEN_PIN, OUTPUT);
  pinMode(BLUE_PIN, OUTPUT);
  pinMode(13, OUTPUT);

  pinMode(FotoRezistor, INPUT); //Фоторезистор
  pinMode(Switch_1, INPUT); //Тумблер 1
  pinMode(Switch_2, INPUT); //Тумблер 2
  
  Serial.begin(9600);

  for(byte a = 0; a < 2; a++){
    setRGB(50,0,0);
    delay(150);
    setRGB(0,0,0);
    delay(150);
  }

  setRGB(eeprom_read_byte(0), eeprom_read_byte(1), eeprom_read_byte(2));
}

void loop(){
  if(Serial.available() > 0){
    byte packetId = Serial.read();

    switch(packetId){
      case 1:{
        Serial.readBytes(rgb, 3);
        setRGB(rgb[0], rgb[1], rgb[2]);

        for(int a = 0; a < 3; a++)
          eeprom_write_byte(a, rgb[a]);
        
        break;
      }
    }
  }

  Serial.write(digitalRead(Switch_1));
  Serial.write(digitalRead(Switch_2));
  Serial.write(analogRead(FotoRezistor));

  delay(100);
}

void setRGB(byte r, byte g, byte b){
  analogWrite(RED_PIN, r);
  analogWrite(GREEN_PIN, g);
  analogWrite(BLUE_PIN, b);  
}

void func(int pin){
  for(int a = 0; a < 255; a++){ analogWrite(pin,a); delay(10); }
  for(int a = 255; a > 0; a--){ analogWrite(pin,a); delay(10); }
}
