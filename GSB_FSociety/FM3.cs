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
            bsFicheRemboursement.DataSource = ModelGSB.GetListeFicheFrais();
            dgvFicheForfait.DataSource = bsFicheRemboursement;
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            FM3New fm3n = new FM3New();
            fm3n.ShowDialog();
        }
    }
}
