using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cto9n
{
    public partial class Limits : Form
    {
        List<Panel> listPanels = new List<Panel>();

        public Limits()
        {
            InitializeComponent();
        }

        private void primCondButton_Click(object sender, EventArgs e)
        {
            primCond.Enabled = true;
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            areaType.Enabled = true;
        }

        private void Limits_Load(object sender, EventArgs e)
        {
            listPanels.Add(areaType);
            listPanels.Add(boundTime);
            listPanels.Add(areaBounds);
            listPanels.Add(primCond);
            listPanels.Add(edgeCond);
           // listPanels.Add(empty);
           // listPanels[0].BringToFront();

        }

        private void bounded_Click(object sender, EventArgs e)
        {
            boundTime.Visible = true;
            areaType.Visible = false;
            //listPanels[2].BringToFront();
        }

        private void timeConfirm_Click(object sender, EventArgs e)
        {
            boundTime.Visible = false;
            areaBounds.Visible = true;
            //listPanels[3].BringToFront();
        }

        private void boundsConfirm_Click(object sender, EventArgs e)
        {
            areaBounds.Visible = false;
            areaType.Visible = true;
            areaType.Enabled = false;
            //listPanels[0].BringToFront();
        }

        private void boundCondButton_Click(object sender, EventArgs e)
        {
            edgeCond.Enabled = true;
        }

        private void edgeConfirm_Click(object sender, EventArgs e)
        {
            edgeCond.Enabled = false;
        }

        private void areaType_Paint(object sender, PaintEventArgs e)
        {

        }

        private void primConfirm_Click_1(object sender, EventArgs e)
        {
            primCond.Enabled = false;
        }

        private void areaBounds_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
