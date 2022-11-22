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
    public partial class FM3 : Form
    {
        public FM3()
        {
            InitializeComponent();
        }

        private void FM3_Load(object sender, EventArgs e)
        {
            bsFicheRemboursement.DataSource = ModelMission3.getFicheFraisUser("a13");
            dgvFicheForfait.DataSource = bsFicheRemboursement;
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            FMois fmois = new FMois();
            fmois.ShowDialog();
        }
    }
}
