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
            bdsHotellerie.DataSource = ModelMission3.getFraisForfaitHotel();
            dgvHotel.DataSource = bdsHotellerie;
            dgvHotel.Columns[4].Visible = false;
            dgvHotel.Columns[0].Visible = false;
        }
    }
}
