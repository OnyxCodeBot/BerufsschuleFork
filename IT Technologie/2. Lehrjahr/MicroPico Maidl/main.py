from machine import Pin
import utime

tRed = Pin(0, Pin.OUT)
tOrange = Pin(1, Pin.OUT)
tGreen = Pin(2, Pin.OUT)

fRed = Pin(3, Pin.OUT)
fGreen = Pin(4, Pin.OUT)

tRed.high()

def switchStateTraffic():
    if tRed.value() == 1:
        tRed.low()
        tOrange.high()
        utime.sleep(2)
        tOrange.low()
        tGreen.high()
    elif tGreen.value() == 1:
        tGreen.low()
        tOrange.high()
        utime.sleep(2)
        tOrange.low()
        tRed.high()

def switchStateFoot():
    if fRed.value() == 1:
        fRed.low()
        fGreen.high()
    elif fGreen.value() == 1:
        fGreen.low()
        fRed.high()

while True:
    utime.sleep(5)
    print("Ampel schält um")
    switchStateTraffic()