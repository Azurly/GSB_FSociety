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
            bsMedecin.DataSource = ModelGSB.GetListeMedecin();
            cbxMedecin.DataSource = bsMedecin;
            cbxMedecin.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMedecin.ValueMember = "idMedecin";
            cbxMedecin.DisplayMember = "nom";


            bsMotif.DataSource = ModelGSB.GetListeMotif();
            cbxMotif.DataSource = bsMotif;
            cbxMotif.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMotif.ValueMember = "idMotif";
            cbxMotif.DisplayMember = "libMotif";

            tbRemplacent.Enabled = false;

            string[] columns = { "id", "nom commerciale", "id famille", "effets", "contre-indications", "composition", "qte"};
            for(int i=0; i<columns.Length; i++) { dgvMedicamentPresenter.Columns.Add(columns[i], columns[i]); }

 
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            RAPPORT r = new RAPPORT();
            r.dateRapport = DtpDate.Value;
            r.MOTIF = (MOTIF)bsMotif.Current;
            r.Visiteur = (Visiteur)ModelGSB.GetUtilisateurConnecte;
            r.MEDECIN = (MEDECIN)bsMedecin.Current;

            List<MEDICAMENT> lm = new List<MEDICAMENT>();
            dgvMedicamentPresenter.Rows[0].Cells[0].Value = "test";
            lbltest.Text = dgvMedicamentPresenter.Rows[0].Cells[0].Value.ToString();

            foreach(DataGridViewRow row in dgvMedicamentPresenter.Rows){

                MEDICAMENT m = new MEDICAMENT();
                //m.idMedicament = Convert.ToIntrow.Cells[0].Value.;
                
    
            }


            //List<OFFRIR> lo = new List<OFFRIR>();
            //OFFRIR o = new OFFRIR();
            //o.RAPPORT = r;

            //for (int i = 0; i < dgvMedicament.Rows.Count; i++)
            //{
            //    for (int j = 0; i < dgvMedicament)
            //}

        }

        private void dgvMedicament_CurrentCellChanged(object sender, EventArgs e)
        {
            dgvMedicamentPresenter.Rows[0].Cells[0].Value = "test";
        }

        private void checkBoxRemplacent_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRemplacent.Checked){ tbRemplacent.Enabled = true; }
            else{ tbRemplacent.Enabled = false; }
        }
    }
}
