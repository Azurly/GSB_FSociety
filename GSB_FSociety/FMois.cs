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
    public partial class FMois : Form
    {
        public FMois()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ModelMission3.mois = NumMois.Value;
            ModelMission3.annee = NumAnnee.Value;
            FM3New fm3n = new FM3New();
            fm3n.ShowDialog();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
