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

        public static void init()
        {
            maConnexion = new connnectGSBFSociety();
        }
        public static List<FraisForfait> getFraisForfaitHotel()
        {
            return maConnexion.FraisForfait.Where(x => x.id != "KM").ToList();
        }
    }
}
