using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubDataAccessLayer
{
    public class DalManager
    {
        public List<House> Houses { get; set; }
        public List<Territory> Territories { get; set; }
        public List<Character> Personnages { get; set; }

        Character p1 = new Character("Alhaouche", "Delort");
        Character p2 = new Character("Moussa", "Bane", 2, 2, 2, new RelationshipEnum[] { RelationshipEnum.FRIENDSHIP, RelationshipEnum.LOVE }, CharacterTypeEnum.LEADER);
        Character p3 = new Character("Mamadou", "Bane", 2, 2, 2, new RelationshipEnum[] { RelationshipEnum.FRIENDSHIP, RelationshipEnum.LOVE }, CharacterTypeEnum.LEADER);
      
        public DalManager()
        {
            Houses = new List<House>();
            Houses.Add(new House("house1", 50));
            Houses.Add(new House("house2", 204));
            Houses.Add(new House("house3", 314));

            Territories = new List<Territory>();
            Territories.Add(new Territory(TerritoryType.DESSERT, p1));
            Territories.Add(new Territory(TerritoryType.LAND, p2));
            Territories.Add(new Territory(TerritoryType.SEA, p3));

            Personnages = new List<Character>();
            Personnages.Add(p1);
            Personnages.Add(p2);
            Personnages.Add(p3);
        }

        

        public List<House> ListeMaisonsExistantes()
        {
            return Houses;
        }

        public List<House> ListeMaisonsExistantesPlus200Unites()
        {
            List<House> listeMaisons = new List<House>();
            listeMaisons = (List<House>) Houses.Where((house) => house.NumberOfUnities >= 200);
            return listeMaisons;
        }

        public List<Territory> ListeTerrainsExistants()
        {
            return Territories;
        }

        public List<string> ListePersonnagesExistants()
        {
            List<string> listePersonnages = new List<string>();
            foreach(var personnage in Personnages)
                listePersonnages.Add(personnage.FirstName);
            return listePersonnages;
        }

        public List<Character> ListeCaracteristiquesPersonnagesExistants()
        {
            return Personnages;
        }
    }
}
