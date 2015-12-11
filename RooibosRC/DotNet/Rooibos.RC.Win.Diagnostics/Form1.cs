using Rooibos.Library;
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
        private RC.IO.RCBridge _Bridge;
        private Thread _TestThread;
        private Test _Test = new Test();


        private XBox360Plane m_controller;
        private Thread m_controllerThread;
        private Thread m_timerThread;

        private DateTime m_timeOpened;

        public Form1()
        {
            InitializeComponent();

            m_controller = new XBox360Plane(ConvertNice.ToInt32(numericUpDownAileronsMaxDegrees.Value), ConvertNice.ToInt32(numericUpDownAileronsMinDegrees.Value), ConvertNice.ToInt32(numericUpDownAileronsLevelDegrees.Value),
                ConvertNice.ToInt32(numericUpDownElevatorsMaxDegrees.Value), ConvertNice.ToInt32(numericUpDownElevatorsMinDegrees.Value), ConvertNice.ToInt32(numericUpDownElevatorsLevelDegrees.Value),
                ConvertNice.ToInt32(numericUpDownRudderMaxDegrees.Value), ConvertNice.ToInt32(numericUpDownRudderMinDegrees.Value), ConvertNice.ToInt32(numericUpDownRudderLevelDegrees.Value));

            m_controller.OnInputChangedEvent += m_controller_OnInputChangedEvent;

            m_controllerThread = new Thread(m_controller.ControllerStart);
            m_timerThread = new Thread(StartTimer);
        }

        private void m_controller_OnInputChangedEvent(object sender, int angleAilerons, int angleElevators, int angleRudder, int power)
        {
            string prefix = "";

            if (checkBoxMode.Checked)
            {
                prefix = "FWD_";
            }
            
            _Bridge.SendCommand(prefix + IO.Commands.Plane.AILO.Command, angleAilerons.ToString());
            _Bridge.SendCommand(prefix + IO.Commands.Plane.ELEV.Command, angleElevators.ToString());
            _Bridge.SendCommand(prefix + IO.Commands.Plane.RUDD.Command, angleRudder.ToString());
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
                _Test.Stop = true;
                _TestThread.Abort();
                _Bridge.Close();

                btnStartStop.Text = "Start Test";
            }
        }

        private void BeginTest()
        {
            string prefix = "";

            if (checkBoxMode.Checked)
            {
                prefix = "FWD_";
            }

            List<string[]> commands = new List<string[]>();
            commands.Add(new string[] { prefix + IO.Commands.RSET.Command, ConvertNice.ToInt32(numericUpDownAileronsMaxDegrees.Value).ToString() });

            commands.Add(new string[] { prefix + IO.Commands.Plane.AILO.Command, ConvertNice.ToInt32(numericUpDownAileronsMaxDegrees.Value).ToString() });
            commands.Add(new string[] { prefix + IO.Commands.Plane.AILO.Command, ConvertNice.ToInt32(numericUpDownAileronsMinDegrees.Value).ToString() });
            commands.Add(new string[] { prefix + IO.Commands.Plane.AILO.Command, ConvertNice.ToInt32(numericUpDownAileronsLevelDegrees.Value).ToString() });

            commands.Add(new string[] { prefix + IO.Commands.ECHO.Command, "" });

            commands.Add(new string[] { prefix + IO.Commands.Plane.ELEV.Command, ConvertNice.ToInt32(numericUpDownElevatorsMaxDegrees.Value).ToString() });
            commands.Add(new string[] { prefix + IO.Commands.Plane.ELEV.Command, ConvertNice.ToInt32(numericUpDownElevatorsMinDegrees.Value).ToString() });
            commands.Add(new string[] { prefix + IO.Commands.Plane.ELEV.Command, ConvertNice.ToInt32(numericUpDownElevatorsLevelDegrees.Value).ToString() });

            commands.Add(new string[] { prefix + IO.Commands.ECHO.Command, "" });

            commands.Add(new string[] { prefix + IO.Commands.Plane.RUDD.Command, ConvertNice.ToInt32(numericUpDownRudderMaxDegrees.Value).ToString() });
            commands.Add(new string[] { prefix + IO.Commands.Plane.RUDD.Command, ConvertNice.ToInt32(numericUpDownRudderMinDegrees.Value).ToString() });
            commands.Add(new string[] { prefix + IO.Commands.Plane.RUDD.Command, ConvertNice.ToInt32(numericUpDownRudderLevelDegrees.Value).ToString() });

            commands.Add(new string[] { prefix + IO.Commands.ECHO.Command, "" });

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

                if (checkBoxAutoScroll.Checked)
                {
                    if (dataGridViewIO.Rows.Count > 0)
                    {
                        dataGridViewIO.FirstDisplayedScrollingRowIndex = dataGridViewIO.FirstDisplayedScrollingRowIndex + 1;
                    }
                }
            });
        }

        private void StartTimer()
        {
            toolStripStatusLabelTimeOpen.Text = (DateTime.Now - m_timeOpened).Seconds.ToString();

            Thread.Sleep(1000);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (buttonOpen.Text.Equals("Open"))
            {
                _Bridge = new IO.RCBridge(comboBoxPorts.SelectedItem.ToString());
                _Bridge.MessageTerminator = textBoxProtocolTerminator.Text.Trim()[0];
                _Bridge.OnCommandReceivedEvent += _Bridge_OnCommandReceivedEvent;
                _Bridge.Open();

                buttonOpen.Text = "Close";
                

                m_controllerThread.Start();

                comboBoxPorts.Enabled = false;

                btnStartStop.Enabled = true;

                textBoxProtocolTerminator.Enabled = false;

                m_timeOpened = DateTime.Now;
                m_timerThread.Start();
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

                textBoxProtocolTerminator.Enabled = true;
                m_timerThread.Abort();
            }
        }

        private void buttonOpen_Click_1(object sender, EventArgs e)
        {

        }
        
    }
}
