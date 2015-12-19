#include <Servo.h>

#include <Mirf.h>
#include <MirfHardwareSpiDriver.h>
#include <MirfSpiDriver.h>
#include <nRF24L01.h>

int m_bufLen = 0;
int m_bytesRead = 0;
char m_message[512];

int m_wirelessBufLen = 0;
int m_wirelessBytesRead = 0;
char m_wirelessMessage[512];

const String EndpointSerial = "SERIAL";
const char EndOfMessage = '?';
const String Deliminator = "=";

const boolean IsVehicle = true;

// Pins
const int PinServoElevators = 6;
const int PinServoAilerons = 7;
const int PinServoRudder = 8;
const int PinMotor = 5;

// Default servo positions (level)
const int AileronsDegreeLevel = 90;
const int RudderDegreeLevel = 125;
const int ElevatorsDegreeLevel = 120;

// Motor Power
const int PowerMin = 100;
const int PowerMax = 170;

const boolean Debug = true;

Servo m_rudder;
Servo m_ailerons;
Servo m_elevators;
Servo m_motor;

int m_motorPower = 0;

void setup() {

  m_wirelessBufLen = sizeof(m_wirelessMessage) / sizeof(m_wirelessMessage[0]);
  m_bufLen = sizeof(m_message) / sizeof(m_message[0]);
  
  Serial.begin(9600);

  Mirf.csnPin = 10;
  Mirf.cePin = 9;
  Mirf.spi = &MirfHardwareSpi;
  Mirf.init();

  if (IsVehicle == true)
  {
    Mirf.setRADDR((byte *)"veh01");
    Mirf.setTADDR((byte *)"rec01");

    m_elevators.attach(PinServoElevators);
    m_ailerons.attach(PinServoAilerons);
    m_rudder.attach(PinServoRudder);
    m_motor.attach(PinMotor);
    
    MoveServo(m_ailerons, AileronsDegreeLevel);
    MoveServo(m_elevators, ElevatorsDegreeLevel);
    MoveServo(m_rudder, RudderDegreeLevel);

    m_motor.write(180); // Start Motor
    delay(2000);
  }
  else
  {
    Mirf.setRADDR((byte *)"rec01");
    Mirf.setTADDR((byte *)"veh01");   
  }
  
  Mirf.payload = 32;
  Mirf.config();
}

void loop() {
  
  String message = GetMessage(EndpointSerial);

  if (!message.equals(""))
  {
    String command;
    String value;
  
    if (!ParseMessage(message, command, value))
    {
      WriteMessage(CreateCommand("FAILURE", "COULD NOT PARSE"), EndpointSerial);
    }
    else 
    {
      if (Debug)
      {
        WriteMessage(CreateCommand("DBG_" + command, value), EndpointSerial);
      }
      
      if ((command.length() >= 4) && (command.substring(0,4) == "FWD_")) // send to device
      {
        String cmd = command.substring(4, command.length());
        WriteMessage(CreateCommand(cmd, value),"");
      }
      else if (command == "ECHO")
      {
        if (IsVehicle)
        {
          WriteMessage(CreateCommand("HELO", "HELLO VEHICLE SERIAL"), EndpointSerial);
        }
        else
        {
          WriteMessage(CreateCommand("HELO", "HELLO FROM CONTROLLER"), EndpointSerial);
        }
      }
      else
      {
        RunCommand(command, value, true, message);
      }
    }
  }

  String wirelessMessage = GetMessage("");

  if (!wirelessMessage.equals(""))
  {
    String command;
    String value;
  
    if (!ParseMessage(wirelessMessage, command, value))
    {
      WriteMessage(CreateCommand("FAILURE", "COULD NOT PARSE WL"), "");
    }
    else 
    {
      if (Debug)
      {
        WriteMessage(CreateCommand("DBG_" + command, value), EndpointSerial);
      }
      
      if (IsVehicle == false) // send to controller
      {
        WriteMessage(CreateCommand(command, value), EndpointSerial);
      }
      else if (command == "ECHO")
      {
        WriteMessage(CreateCommand("HELO", "HELLO VEHICLE WLESS"), "");
      }
      else
      {
        RunCommand(command, value, false, wirelessMessage);
      }
    }
  }
}

void MoveServo(Servo &servo, String value)
{
	int angle = servo.read();

	if (value == "UP")
	{
		if ((angle + 1) <= 180)
		{
			angle = angle + 1;
		}
	}
	else if (value == "DOWN")
	{
		if ((angle -1) > 0)
		{
			angle = angle - 1;
		}
	}
	else
	{
		angle = value.toInt();
	}

  if (servo.read() != angle)
  {
    servo.write(angle);
  }
}

void RunCommand(const String command, const String value, const boolean wasRecBySerial, const String originalMessage)
{
  if (command == "AILO")
  {
    MoveServo(m_ailerons, value);
  }
  else if (command == "ELEV")
  {
    MoveServo(m_elevators, value);
  }
  else if (command == "RUDD")
  {
    MoveServo(m_rudder, value);
  }
  else if (command == "POWR")
  {
    ChangePower(value);
  }
  else if (command == "RSET")
  {
    MoveServo(m_ailerons, AileronsDegreeLevel);
    MoveServo(m_elevators, ElevatorsDegreeLevel);
    MoveServo(m_rudder, RudderDegreeLevel);
  }
}

void ChangePower(String value)
{
  int power = m_motor.read();

  if (value == "UP")
  {
	if ((value + 1) <= 180)
	{
	   power = value.toInt();
	}
  }
  else if (value == "DOWN")
  {
	if ((value - 1) >= 0)
	{
		power = value.toInt();
	}
  }
  else
  {
	power = value.toInt();
  }

  if (power > PowerMax)
  {
    m_motorPower = PowerMax;
  }
  else if (power < PowerMin)
  {
    m_motorPower = PowerMin;
  }
  else
  {
    m_motorPower = power;
  }

  if (m_motorPower != m_motor.read())
  {
	m_motor.write(m_motorPower);
  }
}

void WriteMessage(String message, String endpointType)
{

  if (endpointType.equals(EndpointSerial))
  {
    Serial.print(message + EndOfMessage);
    Serial.print('\0');
  }
  else // Wireless
  {
    message = message + EndOfMessage;

    // todo - make this smarter so can send more than 32 bytes without losing data (need to loop)
    char data[32];
      message.toCharArray(data, 32);
      Mirf.send((byte *) data);

      while(Mirf.isSending())
      {   
        Serial.println(".."); // weird - only works if i write something to the serial port :wtf!
      }

      delay(1);
  }
}

boolean ParseMessage(const String &message, String &key, String &value)
{
  int deliminator = message.indexOf(Deliminator);

  if (deliminator == -1)
  {
    return false;
  }

  key = message.substring(0, deliminator);
  value = message.substring(deliminator + 1);

  return true;
}

String GetMessage(const String endpointType)
{ 
  if (endpointType.equals(EndpointSerial))
  {
    if (Serial.available() > 0)
    {
      byte c = Serial.read();

      if (c == EndOfMessage)
      {
        if (m_bytesRead == 0)
        {
          return "";
        }
        
        if (m_bytesRead == m_bufLen)
        {
          m_bytesRead = 0;
          return String(m_message);
        }
        
        m_message[m_bytesRead] = '\0'; 
        m_bytesRead = 0;
        return String(m_message);
      }
    
      if (m_bufLen == m_bytesRead + 1)
      {
        WriteMessage(CreateCommand("FAILURE","Message is too long! You need to resend."), endpointType);
        m_bytesRead = 0;
      }
      else
      {
        m_message[m_bytesRead] = c;
        m_bytesRead++; 
      }
    }
  }
  else // Wireless
  {
     if(Mirf.dataReady())
     {
          byte data[32];
          Mirf.getData((byte *) &data);
          
          for(int i = 0; i < 32; i++)
          {
            if (data[i] == 0)
            {
              break;
            }

            char ch[2];
            ch[0] = data[i];
            ch[1] = '\0';

            //Serial.println(ch);

            if (ch[0] == EndOfMessage)
            {
              if (m_wirelessBytesRead == 0)
              {
                return "";
              }

              if (m_wirelessBytesRead == m_wirelessBufLen)
              {
                m_wirelessBytesRead = 0;
                return String(m_wirelessMessage);
              }
        
              m_wirelessMessage[m_wirelessBytesRead] = '\0'; 
              m_wirelessBytesRead = 0;
              return String(m_wirelessMessage);
            }

            if (m_wirelessBufLen == m_wirelessBytesRead + 1)
            {
              WriteMessage(CreateCommand("FAILURE","Message is too long! You need to resend."), endpointType);
              m_wirelessBytesRead = 0;
            }
            else
            {
              m_wirelessMessage[m_wirelessBytesRead] = ch[0];
              m_wirelessBytesRead++; 
            }
          }
     }
  }

  return "";
}

String CreateCommand(String command, String value)
{
  return command + String(Deliminator) + value;
}

