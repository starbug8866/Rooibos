using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using Rooibos.RC.IO;

namespace Rooibos.RC.IO
{
    public class RCBridge : IDisposable
    {
        private SerialPort _Port;
        private char _MessageTerminator = '?';
        
        private MemoryStream _s = new MemoryStream();
        private bool m_cont = false;

        public delegate void OnCommandReceivedEventHandler(object sender, string command, string value);

        public event OnCommandReceivedEventHandler OnCommandReceivedEvent;

        public char MessageTerminator
        {
            get
            {
                return _MessageTerminator;
            }
            set
            {
                _MessageTerminator = value;
            }
        }

        public RCBridge(string portName)
        {
            _Port = new SerialPort(portName, 9600);

            _Port.DataReceived += _Port_DataReceived;
        }

        private void _Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (this.OnCommandReceivedEvent == null) // No point processing it no one wants to know :(
            {
                return;
            }

            byte[] buffer = new byte[1];
            int i = 0;

            try
            {
                while ((_Port.IsOpen) && ((i = _Port.Read(buffer, 0, buffer.Length)) > 0) && (m_cont))
                {
                    if (Encoding.ASCII.GetString(buffer).Equals(_MessageTerminator.ToString()))
                    {
                        string[] parts = Encoding.ASCII.GetString(_s.ToArray()).Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                        if (parts.Length != 0)
                        {

                            if (parts.Length == 1)
                            {
                                this.OnCommandReceivedEvent(this, parts[0].Replace(".", "").Trim(), null);

                            }
                            else if (parts.Length == 2)
                            {
                                this.OnCommandReceivedEvent(this, parts[0].Replace(".", "").Trim(), parts[1]);
                            }
                            else
                            {
                                StringBuilder value = new StringBuilder();

                                for (int x = 1; x < parts.Length; x++)
                                {
                                    value.Append(parts[x]);
                                }

                                this.OnCommandReceivedEvent(this, parts[0], value.ToString());
                            }
                        }

                        _s = new MemoryStream();

                        break;
                    }

                    _s.Write(buffer, 0, buffer.Length);
                }
            }
            catch  (System.IO.IOException damn)
            {
                // TODO
            }
            catch (System.Threading.ThreadAbortException goodbye)
            {
                this.Dispose();
            }
        }

        public void Open()
        {
            if (!_Port.IsOpen)
            {
                m_cont = true;
                _s = new MemoryStream();
                _Port.Open();
            }
        }

        public void Close()
        {
            if (_Port.IsOpen)
            {
                m_cont = false;
                _Port.Close();
            }
        }

        public void SendCommand(IO.IRCCommand<object> command)
        {
            string cmd = command.GetCommand();
            string value = command.GetValue();

            string message = string.Format("{0}={1}{2}", cmd, value, _MessageTerminator);
            byte[] bMessage = Encoding.ASCII.GetBytes(message);

            _Port.Write(bMessage, 0, bMessage.Length);
        }

        public void SendCommand(string command, string value)
        {
            string message = string.Format("{0}={1}{2}", command, value, _MessageTerminator);

            byte[] bMessage = Encoding.ASCII.GetBytes(message);

            _Port.Write(bMessage, 0, bMessage.Length);
        }

        public void Dispose()
        {
            this.Close();
        }
    }
}
