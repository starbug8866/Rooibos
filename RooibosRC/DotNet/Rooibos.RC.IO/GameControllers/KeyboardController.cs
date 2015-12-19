using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rooibos.RC.IO.GameControllers
{
    public class KeyboardController
    {
        public char KeyUp = 'W';
        public char KeyDown = 'S';
        public char KeyLeft = 'A';
        public char KeyRight = 'D';
        public char PowerUp = 'P';
        public char PowerDown = 'L';
        public char RudderLeft = 'H';
        public char RudderRight = 'j';

        private RCBridge Bridge { get; set; }    
        public Form AttachedForm { get; private set; }                                                                               
        
        public KeyboardController(RCBridge bridge)
        {
            Bridge = bridge;
        }

        public KeyboardController(RCBridge bridge, Form form)
        {
            Bridge = bridge;
            AttachedForm = form;

            form.KeyDown += Form_KeyDown;
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            KeyPressDown(((char)e.KeyValue).ToString().ToUpper()[0]);
        }

        public void KeyPressDown(char key)
        {
            if (key.Equals(KeyUp))
            {
                Bridge.SendCommand(Commands.Plane.ELEV.Command, "UP");
            }
            else if (key.Equals(KeyDown))
            {
                Bridge.SendCommand(Commands.Plane.ELEV.Command, "DOWN");
            }
            else if (key.Equals(KeyLeft))
            {
                Bridge.SendCommand(Commands.Plane.AILO.Command, "UP");
            }
            else if (key.Equals(KeyRight))
            {
                Bridge.SendCommand(Commands.Plane.AILO.Command, "DOWN");
            }
            else if (key.Equals(PowerUp))
            {
                Bridge.SendCommand(Commands.Plane.POWR.Command, "UP");
            }
            else if (key.Equals(PowerDown))
            {
                Bridge.SendCommand(Commands.Plane.POWR.Command, "DOWN");
            }
            else if (key.Equals(RudderLeft))
            {
                Bridge.SendCommand(Commands.Plane.RUDD.Command, "DOWN");
            }
            else if (key.Equals(RudderRight))
            {
                Bridge.SendCommand(Commands.Plane.RUDD.Command, "UP");
            }
        }
    }
}
