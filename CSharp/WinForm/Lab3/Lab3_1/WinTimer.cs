using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_1
{
    public partial class WinTimer : Form
    {
        public WinTimer()
        {
            InitializeComponent();
        }

        private void StartStop_Click(object sender, EventArgs e)
        {
            if (userControlTimer.TimeEnabled == true)
                userControlTimer.TimeEnabled = false;
            else
                userControlTimer.TimeEnabled = true;
        }
    }
}
