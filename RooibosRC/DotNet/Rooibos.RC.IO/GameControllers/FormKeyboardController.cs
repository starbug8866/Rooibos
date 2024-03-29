﻿using System;
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
    public partial class FormKeyboardController : Form
    {
        private KeyboardController m_keyboardController;

        public FormKeyboardController(RCBridge bridge)
        {
            m_keyboardController = new KeyboardController(bridge);

            InitializeComponent();
        }

        private void KeyboardControllerForm_KeyDown(object sender, KeyEventArgs e)
        {
            m_keyboardController.KeyPressDown(((char)e.KeyValue).ToString().ToUpper()[0]);
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

        private void KeyboardControllerForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += KeyboardControllerForm_KeyDown;

            btnDown.Text = m_keyboardController.KeyDown.ToString();
            btnLeft.Text = m_keyboardController.KeyLeft.ToString();
            btnPowerDown.Text = m_keyboardController.PowerDown.ToString();
            btnPowerUp.Text = m_keyboardController.PowerUp.ToString();
            btnRight.Text = m_keyboardController.KeyRight.ToString();
            btnLeft.Text = m_keyboardController.KeyLeft.ToString();

            buttonRudderLeft.Text = m_keyboardController.RudderLeft.ToString();
            buttonRudderRight.Text = m_keyboardController.RudderRight.ToString();
        }
    }
}
