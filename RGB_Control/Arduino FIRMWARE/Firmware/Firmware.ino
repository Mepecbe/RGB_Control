/*
    Доступные команды(приём через сериал порт с Baud rate = 9600), каждый операнд - 1 байт
        0 R G B - установить цвета r, g, b
        1 R G B - установить цвета r, g, b и записать их в EEPROM
        3 - запрос информации о состоянии тумблеров и фоторезистора
            Микроконтроллер отвечает в порт 3-мя байтами:
            S1 S2 F1 где: 
              S1 - состояние тумблера 1 (0 или 1)
              S2 - состояние тумблера 2 (0 или 1)
              F1 - состояние фоторезистора (0 - 255) 
*/


#define RED_PIN   9
#define GREEN_PIN 11
#define BLUE_PIN  10
#define Switch_1 2
#define Switch_2 4
#define FotoRezistor A0

byte rgb[] = {0,0,0};

void setup() {
  // Пины D9 и D10 - 31.4 кГц
  TCCR1A = 0b00000001;  // 8bit
  TCCR1B = 0b00000001;  // x1 phase correct

  // Пины D3 и D11 - 31.4 кГц
  TCCR2B = 0b00000001;  // x1
  TCCR2A = 0b00000001;  // phase correct
   
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
      case 0:{
        Serial.readBytes(rgb, 3);
        setRGB(rgb[0], rgb[1], rgb[2]);

        break;
      }

      case 1:{
        Serial.readBytes(rgb, 3);
        setRGB(rgb[0], rgb[1], rgb[2]);

        for(int ByteIndex = 0; ByteIndex < 3; ByteIndex++)
          eeprom_write_byte(ByteIndex, rgb[ByteIndex]);
        
        break;
      }

      case 2:{
        Serial.write(digitalRead(Switch_1));
        Serial.write(digitalRead(Switch_2));
        int val1 = analogRead(FotoRezistor);
        delay(10);
        int val2 = analogRead(FotoRezistor);
        delay(10);        
        Serial.write((analogRead(FotoRezistor) + val1 + val2) / 3);
      }     
    }
  }
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
