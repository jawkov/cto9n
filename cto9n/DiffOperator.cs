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
    public partial class DiffOperator : Form
    {
        Thread th;

        public DiffOperator()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openLimitsForm);
            th.Start();
        }

        private void openLimitsForm()
        {
            Application.Run(new Limits());
        }
    }
}
