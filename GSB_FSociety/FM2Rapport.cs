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
    public partial class FM2Rapport : Form
    {
        public FM2Rapport()
        {
            InitializeComponent();
        }


        private void FM2Rapport_Load(object sender, EventArgs e)
        {
            
        }
        private void BtnValider_Click(object sender, EventArgs e)
        {
            RAPPORT r = new RAPPORT();
            r.dateRapport = DtpDate.Value;
            //r.MOTIF = CbxMotif.Value
        }
    }
}
