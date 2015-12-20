using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rooibos.RC.IO.GameControllers
{
    public partial class KeyboardControllerForm : Form
    {
        private KeyboardController m_keyboardController;

        public KeyboardControllerForm(RCBridge bridge)
        {
            m_keyboardController = new KeyboardController(bridge, this);

            InitializeComponent();
        }

        private void btnPowerUp_Click(object sender, EventArgs e)
        {
            btnPowerUp.PerformClick();
        }

        private void btnPowerDown_Click(object sender, EventArgs e)
        {
            btnPowerDown.PerformClick();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            btnLeft.PerformClick();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            btnUp.PerformClick();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            btnDown.PerformClick();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            btnRight.PerformClick();
        }

        private void buttonRudderLeft_Click(object sender, EventArgs e)
        {
            buttonRudderLeft.PerformClick();
        }

        private void buttonRudderRight_Click(object sender, EventArgs e)
        {
            buttonRudderRight.PerformClick();
        }
    }
}
