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
    public partial class FM2 : Form
    {
        public FM2()
        {
            InitializeComponent();
        }

        private void RapportTSMI_Click(object sender, EventArgs e)
        {
            FM2Rapport fm2r = new FM2Rapport();
            fm2r.ShowDialog();
        }
    }
}
