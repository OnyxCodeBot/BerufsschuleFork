from machine import Pin
import utime

trigger = Pin(28, Pin.OUT)
echo = Pin(27, Pin.IN)

LEDr = Pin(2, Pin.OUT)
LEDg = Pin(3, Pin.OUT)
LEDb = Pin(4, Pin.OUT)

while True:
  trigger.low()
  utime.sleep(0.005)
  trigger.high()
  utime.sleep(0.01)
  trigger.low()
  dauer = machine.time_pulse_us(echo, 1)
  entfernung = (dauer/2) * 0.03432

  utime.sleep(0.2)
  print(f'{entfernung} cm')

  if entfernung < 10:
    currentPin = 6
  elif entfernung < 20:
    currentPin = 7
  elif entfernung < 30:
    currentPin = 8
  elif entfernung < 40:
    currentPin = 9
  elif entfernung < 50:
    currentPin = 10
  elif entfernung < 60:
    currentPin = 11
  elif entfernung < 70:
    currentPin = 12
  elif entfernung < 80:
    currentPin = 13
  elif entfernung < 90:
    currentPin = 14
  elif entfernung < 100:
    currentPin = 15
  else:
    currentPin = 16

  if entfernung < 20:
    LEDr.high()
    LEDg.low()
    LEDb.low()
  elif entfernung < 100:
    LEDr.low()
    LEDg.high()
    LEDb.low()
  else:
    LEDr.low()
    LEDg.low()
    LEDb.high()

  for x in range (6, currentPin):
    Pin(x, Pin.OUT).low()
  for x in range (currentPin, 16):
    Pin(x, Pin.OUT).high()