#include <Servo.h>

int servoCount = 4;
int servoPins[] = {5, 4, 3, 2};
Servo servos[4];

void setup() {
  Serial.begin(9600);
  AttachServos();
}

void loop() {
  
}

void serialEvent() {
  int channel;
  int pos;
  
  channel = Serial.readStringUntil(':').toInt();
  pos = Serial.readStringUntil('*').toInt();
  servos[channel].write(pos);
}

void AttachServos() {
  for(int i = 0; i < servoCount; i++) {
    servos[i].attach(servoPins[i]);
  }
}
