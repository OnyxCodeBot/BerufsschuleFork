#define trigger 8
#define echo 9

#define rLED 12
#define bLED 11
#define gLED 10

#define BEREIT 3
#define ERKANNT 2
#define FEHLER 1

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);

  pinMode(trigger, OUTPUT);
  pinMode(echo, INPUT);

  pinMode(rLED, OUTPUT);
  pinMode(bLED, OUTPUT);
  pinMode(gLED, OUTPUT);

  pinMode(3, OUTPUT);
  pinMode(4, OUTPUT);
  pinMode(5, OUTPUT);
  pinMode(6, OUTPUT);
  pinMode(7, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  digitalWrite(trigger, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigger, LOW);

  int distance = pulseIn(echo, HIGH);
  Serial.println(distance / 58);

  int state = BEREIT;
  if (distance/58 < 20)
  {
    state = FEHLER;
  }
  else if (distance/58 == 20)
  {
    state = ERKANNT;
    digitalWrite(7, HIGH);
    digitalWrite(6, HIGH);
    digitalWrite(5, HIGH);
    digitalWrite(4, HIGH);
    digitalWrite(3, HIGH);
  }
  else if (distance/58 <= 30)
  {
    state = ERKANNT;
    digitalWrite(7, HIGH);
    digitalWrite(6, HIGH);
    digitalWrite(5, HIGH);
    digitalWrite(4, HIGH);
    digitalWrite(3, LOW);
  }
  else if (distance/58 <= 50)
  {
    state = ERKANNT;
    digitalWrite(7, HIGH);
    digitalWrite(6, HIGH);
    digitalWrite(5, HIGH);
    digitalWrite(4, LOW);
    digitalWrite(3, LOW);
  }
  else if (distance/58 <= 100)
  {
    state = ERKANNT;
    digitalWrite(7, HIGH);
    digitalWrite(6, HIGH);
    digitalWrite(5, LOW);
    digitalWrite(4, LOW);
    digitalWrite(3, LOW);
  }
  else
  {
    state = BEREIT;
    digitalWrite(7, HIGH);
    digitalWrite(6, LOW);
    digitalWrite(5, LOW);
    digitalWrite(4, LOW);
    digitalWrite(3, LOW);
  }

  switch (state)
  {
    case FEHLER:
      digitalWrite(rLED, HIGH);
      digitalWrite(bLED, LOW);
      digitalWrite(gLED, LOW);
      break;
    case ERKANNT:
      digitalWrite(rLED, LOW);
      digitalWrite(bLED, HIGH);
      digitalWrite(gLED, LOW);
      break;
    case BEREIT:
      digitalWrite(rLED, LOW);
      digitalWrite(bLED, LOW);
      digitalWrite(gLED, HIGH);
      break;
  }

  delay(10);
}