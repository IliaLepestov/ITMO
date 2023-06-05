using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_5b
{
    public partial class First_Form : Form
    {
        public First_Form()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Second_Form newForm = new Second_Form();
            newForm.Show();
        }
    }
}
