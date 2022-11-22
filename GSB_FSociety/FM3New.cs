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
            string date = ModelMission3.getMoisNewFiche( ModelMission3.mois , ModelMission3.annee);
            // faire une vérrif de date si il n'existe déja pas un doublon dans la BD !
            bdsFraisForfaitH.DataSource = ModelMission3.getQteH( "a13" , date );
            dgvHotel.DataSource = bdsFraisForfaitH;

            bdsFraisForfaitK.DataSource = ModelMission3.getFraisForfaitKilometrage();
            dgvKilo.DataSource = bdsFraisForfaitK;
        }
    }
}
