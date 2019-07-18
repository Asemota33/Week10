using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10
{
    public partial class EndForm : Form
    {
        public EndForm()
        {
            InitializeComponent();
        }

        private void EndForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            backButton_Click(sender, e);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.MAIN_FORM].Show();
            this.Hide();
        }
    }
}
