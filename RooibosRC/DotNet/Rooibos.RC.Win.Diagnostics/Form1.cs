using Rooibos.RC.IO;
using Rooibos.RC.IO.Commands;
using Rooibos.RC.IO.GameControllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rooibos.RC.Win.Diagnostics
{
    public partial class Form1 : Form
    {
        const int AileronsDegreeLevel = 90;
        const int AileronDegreesMin = 45;
        const int AileronDegreesMax = 135;

        const int RudderDegreesLevel = 125;
        const int RudderDegreesMin = 100;
        const int RudderDegreesMax = 170;

        const int ElevatorsDegreesLevel = 120;
        const int ElevatorsDegreesMin = 70;
        const int ElevatorsDegreesMax = 180;

        private RC.IO.RCBridge _Bridge;
        private Thread _TestThread;
        private Test _Test = new Test();


        private XBox360Plane m_controller;
        private Thread m_controllerThread;

        public Form1()
        {
            InitializeComponent();

            m_controller = new XBox360Plane(AileronDegreesMax, AileronDegreesMin, AileronsDegreeLevel, 
                ElevatorsDegreesMax, ElevatorsDegreesMin, ElevatorsDegreesLevel,
                RudderDegreesMax, RudderDegreesMin, RudderDegreesLevel);

            m_controller.OnInputChangedEvent += m_controller_OnInputChangedEvent;

            m_controllerThread = new Thread(m_controller.ControllerStart);
        }

        private void m_controller_OnInputChangedEvent(object sender, int angleAilerons, int angleElevators, int angleRudder, int power)
        {
            _Bridge.SendCommand("FWD_" + IO.Commands.Plane.AILO.Command, angleAilerons.ToString());
            _Bridge.SendCommand("FWD_" + IO.Commands.Plane.ELEV.Command, angleElevators.ToString());
            _Bridge.SendCommand("FWD_" + IO.Commands.Plane.RUDD.Command, angleRudder.ToString());
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] portNames = SerialPort.GetPortNames();

            comboBoxPorts.Items.AddRange(portNames);
        }

        private void comboBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxPorts.SelectedItem.ToString()))
            {
                buttonOpen.Enabled = true;
                checkBoxMode.Enabled = true;
            }
            else
            {
                buttonOpen.Enabled = false;
                checkBoxMode.Enabled = false;
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text.Equals("START TEST", StringComparison.OrdinalIgnoreCase))
            {
                btnStartStop.Text = "Stop Test";

                _TestThread = new Thread(new ThreadStart(BeginTest));
                _TestThread.Start();
            }
            else
            {
                _TestThread.Abort();
                _Bridge.Close();

                btnStartStop.Text = "Start Test";
            }
        }

        private void BeginTest()
        {
            List<string[]> commands = new List<string[]>();
            commands.Add(new string[] { "FWD_" + IO.Commands.RSET.Command, AileronDegreesMax.ToString() });

            commands.Add(new string[] { "FWD_" + IO.Commands.Plane.AILO.Command, AileronDegreesMax.ToString() });
            commands.Add(new string[] { "FWD_" + IO.Commands.Plane.AILO.Command, AileronDegreesMin.ToString() });
            commands.Add(new string[] { "FWD_" + IO.Commands.Plane.AILO.Command, AileronsDegreeLevel.ToString() });

            commands.Add(new string[] { "FWD_" + IO.Commands.ECHO.Command, "" });

            commands.Add(new string[] { "FWD_" + IO.Commands.Plane.ELEV.Command, ElevatorsDegreesMax.ToString() });
            commands.Add(new string[] { "FWD_" + IO.Commands.Plane.ELEV.Command, ElevatorsDegreesMin.ToString() });
            commands.Add(new string[] { "FWD_" + IO.Commands.Plane.ELEV.Command, ElevatorsDegreesLevel.ToString() });

            commands.Add(new string[] { "FWD_" + IO.Commands.ECHO.Command, "" });

            commands.Add(new string[] { "FWD_" + IO.Commands.Plane.RUDD.Command, RudderDegreesMax.ToString() });
            commands.Add(new string[] { "FWD_" + IO.Commands.Plane.RUDD.Command, RudderDegreesMin.ToString() });
            commands.Add(new string[] { "FWD_" + IO.Commands.Plane.RUDD.Command, RudderDegreesLevel.ToString() });

            commands.Add(new string[] { "FWD_" + IO.Commands.ECHO.Command, "" });

            Test t = new IO.Test();
            t.BeginTest(500, _Bridge, commands);
        }

        private void _Bridge_OnCommandReceivedEvent(object sender, string command, string value)
        {
            string source = "Vehicle";

            if (checkBoxMode.Checked) // Controller
            {
                if (command.Equals(ECHO.Command))
                {
                    if (value.Contains("SERIAL"))
                    {
                        source = "Controller";
                    }
                }
            }
            // else - Talking directly to the vehicle

            dataGridViewIO.Invoke((MethodInvoker)delegate {
                dataGridViewIO.Rows.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), source, command, value);
                
                if (checkBoxAutoScroll.Enabled)
                {
                    dataGridViewIO.FirstDisplayedScrollingRowIndex = dataGridViewIO.FirstDisplayedScrollingRowIndex + 1;
                }
            });
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (buttonOpen.Text.Equals("Open"))
            {
                _Bridge = new IO.RCBridge(comboBoxPorts.SelectedItem.ToString());
                _Bridge.OnCommandReceivedEvent += _Bridge_OnCommandReceivedEvent;
                _Bridge.Open();

                buttonOpen.Text = "Close";
                

                m_controllerThread.Start();

                comboBoxPorts.Enabled = false;

                btnStartStop.Enabled = true;
            }
            else
            {
                _Bridge.Close();
                buttonOpen.Text = "Open";

                m_controllerThread.Abort();

                comboBoxPorts.Enabled = true;

                _Test.Stop = true;
                _TestThread.Abort();
                btnStartStop.Enabled = false;
                btnStartStop.Text = "Start Test";
            }
        }
    }
}
