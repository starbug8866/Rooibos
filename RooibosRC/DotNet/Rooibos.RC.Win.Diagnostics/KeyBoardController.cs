using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rooibos.RC.IO;

namespace Rooibos.RC.Win.Diagnostics
{
    public partial class KeyBoardController : UserControl
    {
        public KeyBoardController()
        {
            InitializeComponent();
        }

        public RCBridge Bridge { get; set; }

        public KeyBoardController(RCBridge bridge)
        {
            bridge = Bridge;
        }
        
        private void btnPowerUp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPowerDown_Click(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {

        }

        private void btnRight_Click(object sender, EventArgs e)
        {

        }

        private void btnDown_Click(object sender, EventArgs e)
        {

        }
    }
}
