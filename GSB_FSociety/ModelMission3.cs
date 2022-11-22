using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_FSociety
{
    internal class ModelMission3
    {
        private static connnectGSBFSociety maConnexion;
        public static decimal mois;
        public static decimal annee;

        public static void init()
        {
            maConnexion = new connnectGSBFSociety();
        }
        public static List<FraisForfait> getFraisForfaitHotel()
        {
            return maConnexion.FraisForfait.Where(x => !x.id.StartsWith("K")).ToList();
        }
        public static Object getFraisForfaitKilometrage()
        {
            return maConnexion.LigneFraisForfait.Where(x => x.FraisForfait.id.StartsWith("K")).Select(x => new { x.FraisForfait.libelle, x.FraisForfait.montant_unitaire, x.quantite }).ToList();
        }
        public static Object getQteH(string user, string mois)
        {
            return maConnexion.LigneFraisForfait.Where(x => x.idVisiteur == user && x.mois == mois ).Select(x => new { x.quantite, x.FraisForfait.libelle, x.FraisForfait.montant_unitaire }).ToList();
        }
        public static Object getFicheFraisUser(string user)
        {
            return maConnexion.fichefrais.Where(x => x.idVisiteur == user).Select(x => new { x.mois, x.montantValide ,x.Etat.libelle }).ToList();
        }
        public static string getMoisNewFiche(decimal mois, decimal annee)
        {
            string strMois = mois.ToString();
            string strAnnee = annee.ToString();
            string date;
            if(mois < 10)
            {
                date = "0"+strMois + strAnnee;
            }
            else
            {
                date = strMois + strAnnee;
            }
            return date;
        }
        public static bool verrifNewFiche(string date) // finire la vérif de date !
        {
            bool vretour = false;


            return vretour;
        }
    }
}
