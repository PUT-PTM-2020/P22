import serial
serialcomm = serial.Serial('COM4', 9600)
serialcomm.timeout = 1
while True:
    print(serialcomm.readline().decode('ascii'))