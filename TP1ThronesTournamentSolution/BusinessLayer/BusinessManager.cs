/*using EntitiesLayer;
using StubDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessManager
    {
        public List<Fight> Fights { get; set; }
        public DalManager DalManager { get; set; }

        public BusinessManager()
        {
            Fights = new List<Fight>();
            Fight fight1 = new Fight();
            Fights.Add(fight1);
            Fights.Add(new Fight());
            DalManager = new DalManager();
        }

        //Utiliser Linq 
        //Type de retour des methodes : listes d'objets
        public List<House> AfficherListeMaisons()
        {
            return DalManager.ListeMaisonsExistantes();
        }

        public List<House> AfficherListeMaisonsPlus200Unites()
        {
            return DalManager.ListeMaisonsExistantesPlus200Unites();
        }

        public List<Character> AfficherPersonnagesPlus3PtsForcePlus50PtsVies()
        {
            List<Character> listePersonnages = new List<Character>();
            listePersonnages = (List<Character>) DalManager.Personnages.Where((personnage) => personnage.Bravoury >= 3 && personnage.Pv >= 50);
            return listePersonnages;
        }

        public List<Territory> AfficherListeTerrains()
        {
            return DalManager.ListeTerrainsExistants();
        }

    }
}
*/