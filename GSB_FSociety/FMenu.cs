using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB_FSociety
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void FMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonMission1_Click(object sender, EventArgs e)
        {
            FM1 fM1 = new FM1();
            fM1.ShowDialog();
        }

        private void buttonMission2_Click(object sender, EventArgs e)
        {
            FM2 fM2 = new FM2();
            fM2.ShowDialog();
        }

        private void buttonMission3_Click(object sender, EventArgs e)
        {
            FM3 fM3 = new FM3();
            fM3.ShowDialog();
        }
    }
}
