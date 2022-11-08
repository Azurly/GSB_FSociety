using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_FSociety
{
    public static class ModelMission2
    {
        private static connnectGSBFSociety maConnexion;
        private static RAPPORT RapportCourant;

        private static UTILISATEUR utilisateurConnecte;
        private static bool connexionValide = false;

        public static void init()
        {
            maConnexion = new connnectGSBFSociety();
        }

        public static RAPPORT GetRapportCourant { get => RapportCourant; }
        public static RAPPORT SetRapportCourant { set => RapportCourant = value; }

        public static UTILISATEUR GetUtilisateurConnecte { get => utilisateurConnecte; }
        public static bool GetConnexionValide { get => connexionValide; }

        public static RAPPORT GetRapportById(int id)
        {
            return maConnexion.RAPPORT.Where(x => x.idRapport == id).FirstOrDefault();
        }

        public static string ValidConnexion(string id, string passwd)
        {
            FindCurrentUserParId(id);
            string Message = "";

            if (utilisateurConnecte == null)
            {
                Message = "Veuillez entrer un identifiant";
            }
            else
            {
                if (passwd.Length == 0) { Message = "Veuillez entrer un mot de passe"; }
                if (utilisateurConnecte.nbessais == 3)
                {
                    Message = "Compte bloqué";
                    utilisateurConnecte.actif = false;
                }
                else
                {

                    if (utilisateurConnecte.idUtilisateur.Equals(id) && utilisateurConnecte.passwd.Substring(2).Equals(GetMd5Hash(passwd)))
                    {
                        utilisateurConnecte.nbessais = 0;
                        connexionValide = true;
                        Message = "Connexion reussi";
                    }
                    else
                    {
                        Message = "Erreur";
                        utilisateurConnecte.nbessais++;
                        connexionValide = false;
                    }
                }
            }

            return Message;
        }

        public static void FindCurrentUserParId(string id)
        {
            utilisateurConnecte = maConnexion.UTILISATEUR.Where(x => x.idUtilisateur == id).FirstOrDefault();
        }


    }
}
