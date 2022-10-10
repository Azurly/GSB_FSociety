using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_FSociety
{
    internal class ModelGSB
    {
        private static Object utilisateurConnecte;
        private static connnectGSBFSociety maConnexion;

        public static void init()
        {
            maConnexion = new connnectGSBFSociety();
        }


        public static Object GetUtilisateurConnecte { get => utilisateurConnecte; }
        public static Object SetUtilisateurConnecte { set => utilisateurConnecte = value; }


        public static List<Etat> GetListeEtat()
        {
            return maConnexion.Etat.ToList();
        }
        public static List<FAMILLE> GetListeFamille()
        {
            return maConnexion.FAMILLE.ToList();
        }
        public static List<fichefrais> GetListeFicheFrais()
        {
            return maConnexion.fichefrais.ToList();
        }

        public static List<FraisForfait> GetListeFraisForfait()
        {
            return maConnexion.FraisForfait.ToList();
        }

        public static List<Laboratoire> GetListeLaboratoiree()
        {
            return maConnexion.Laboratoire.ToList();
        }

        public static List<LigneFraisForfait> GetListeLigneFraisForfait()
        {
            return maConnexion.LigneFraisForfait.ToList();
        }

        public static List<LigneFraisHorsForfait> GetListeLigneFraisHorsForfait()
        {
            return maConnexion.LigneFraisHorsForfait.ToList();
        }
        public static List<MEDECIN> GetListeMedecin()
        {
            return maConnexion.MEDECIN.ToList();
        }

        public static List<MEDICAMENT> GetListeMedicament()
        {
            return maConnexion.MEDICAMENT.ToList();
        }

        public static List<MOTIF> GetListeMotif()
        {
            return maConnexion.MOTIF.ToList();
        }
        public static List<OFFRIR> GetListeOffrir()
        {
            return maConnexion.OFFRIR.ToList();
        }

        public static List<RAPPORT> GetListeRapport()
        {
            return maConnexion.RAPPORT.ToList();
        }

        public static List<Region> GetListeRegion()
        {
            return maConnexion.Region.ToList();
        }

        public static List<Secteur> GetListeSecteur()
        {
            return maConnexion.Secteur.ToList();
        }

        public static List<SPECIALITE> GetListeSpecialite()
        {
            return maConnexion.SPECIALITE.ToList();
        }

        public static List<Visiteur> GetListeVisiteur()
        {
            return maConnexion.Visiteur.ToList();
        }
    }
}
