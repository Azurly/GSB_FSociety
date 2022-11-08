using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace GSB_FSociety
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Red;
            lblMessage.Visible = false;
            tbPassword.UseSystemPasswordChar = true;
            this.AcceptButton = btnValider;
            this.CancelButton = btnAnnuler;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            lblMessage.Text = ModelMission2.ValidConnexion(tbUsername.Text.Trim(), tbPassword.Text.Trim());
            lblMessage.Visible = true;

            if (ModelMission2.GetConnexionValide == true)
            {
                Thread t = new Thread(new ThreadStart(ThreadProc));
                t.Start();
                this.Close();
            }
        }

        private static void ThreadProc()
        {
            Application.Run(new FMenu());
        }

        private bool TestErreur()
        {
            bool pasDerreur = true;
            string m = "Veuillez entrer une valeur.";

            errorProvider1.SetError(tbUsername, "");
            errorProvider1.SetError(tbPassword, "");

            if(tbUsername.Text.Length == 0) { errorProvider1.SetError(tbUsername, m); pasDerreur = false; }
            if(tbPassword.Text.Length == 0) { errorProvider1.SetError(tbPassword, m); pasDerreur = false; }

            if(ModelMission2.GetUtilisateurConnecte){
                lblMessage.Visible = true;
            }
            else{
                if(ModelMission2.GetUtilisateurConnecte.password != tbPassword.Text) {
                    lblMessage.Visible = true;
                    errorProvider1.SetError(tbPassword, "Mauvais mot de passe");
                }

                if (pasDerreur) { ModelMission2.GetUtilisateurConnecte.nbessais = 0; } 
                else { ModelMission2.GetUtilisateurConnecte.nbessais++; }
      
            }
            return pasDerreur;
        }
    }
}
