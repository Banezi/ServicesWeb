using EntitiesLayer;
//using StubDataAccessLayer;
using DataAccessLayer;
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
            DalManager = new DalManager();
        }

        public void addFight(Fight f)
        {
            Fights.Add(f);
        }
        public void addFight(Location l, List<EntitiesLayer.Character> AT, List<EntitiesLayer.Character> BT)
        {
            Fights.Add(new Fight(l, AT, BT));
        }
        
        public List<EntitiesLayer.Character> AfficherPersonnages()
        {
            List<EntitiesLayer.Character> listePersonnages = DalManager.GetCharacters();
            return listePersonnages;
        }
        public EntitiesLayer.Character AfficherPersonnage(string name)
        {
            return DalManager.GetCharacter(name);
        }
        public EntitiesLayer.Character AfficherPersonnage(int Id)
        {
            return DalManager.GetCharacter(Id);
        }
        public List<EntitiesLayer.Team> AfficherEquipe()
        {
            List<EntitiesLayer.Team> listeMaison = DalManager.GetTeams();
            return listeMaison;
        }
    }
}
