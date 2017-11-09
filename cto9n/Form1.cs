using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace cto9n
{
    public partial class Form1 : Form
    {
        Thread th;

        public Form1()
        {
            InitializeComponent();
        }

        private void GreenButton_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openGreenForm);
            th.Start();
            
        }

        private void openGreenForm()
        {
            Application.Run(new GreenFunc());
        }

        private void DiffOperatorButton_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openDiffForm);
            th.Start();
        }

        private void openDiffForm()
        {
            Application.Run(new DiffOperator());
        }
    }
}
