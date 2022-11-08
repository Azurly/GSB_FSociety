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
    public partial class FM2ShowRapport : Form
    {
        private RAPPORT r;
        public FM2ShowRapport()
        {
            InitializeComponent();
            this.r = ModelMission2.GetRapportCourant;
        }

        private void FM2ShowRapport_Load(object sender, EventArgs e)
        {
            lblDate.Text = this.r.dateRapport.ToString();
            //lblMedecin.Text = $"{}";
        }
    }
}
