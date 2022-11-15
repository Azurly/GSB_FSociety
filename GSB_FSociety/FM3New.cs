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
    public partial class FM3New : Form
    {
        public FM3New()
        {
            InitializeComponent();
        }

        private void FM3New_Load(object sender, EventArgs e)
        {
            bdsFraisForfaitH.DataSource = ModelMission3.getFraisForfaitHotel();
            bdsLigneFraisForfait.DataSource = ModelGSB.GetListeLigneFraisForfait();
            dgvHotel.DataSource = bdsFraisForfaitH;
            dgvHotel.Columns[3].Visible = false;
            dgvHotel.Columns[0].Visible = false;
            bdsFraisForfaitK.DataSource = ModelMission3.getFraisForfaitKilometrage();
            dgvKilo.DataSource = bdsFraisForfaitK;
            dgvKilo.Columns[3].Visible = false;
        }
    }
}
