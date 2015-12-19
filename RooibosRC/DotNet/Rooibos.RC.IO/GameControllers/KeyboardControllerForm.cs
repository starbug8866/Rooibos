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
            m_keyboardController.KeyPressDown(m_keyboardController.PowerUp);
        }

        private void btnPowerDown_Click(object sender, EventArgs e)
        {
            m_keyboardController.KeyPressDown(m_keyboardController.PowerDown);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            m_keyboardController.KeyPressDown(m_keyboardController.KeyLeft);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            m_keyboardController.KeyPressDown(m_keyboardController.KeyUp);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            m_keyboardController.KeyPressDown(m_keyboardController.KeyDown);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            m_keyboardController.KeyPressDown(m_keyboardController.KeyRight);
        }

        private void buttonRudderLeft_Click(object sender, EventArgs e)
        {
            m_keyboardController.KeyPressDown(m_keyboardController.RudderLeft);
        }

        private void buttonRudderRight_Click(object sender, EventArgs e)
        {
            m_keyboardController.KeyPressDown(m_keyboardController.RudderRight);
        }
    }
}
