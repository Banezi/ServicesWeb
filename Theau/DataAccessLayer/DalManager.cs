using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;

namespace DataAccessLayer
{
    public class DalManager
    {
        private static DalManager _instance;
        private static readonly object padlock = new object();

        private List<EntitiesLayer.Team> Teams { get; set; }
        private List<EntitiesLayer.Fight> Fights { get; set; }
        private List<EntitiesLayer.Spell> Spells { get; set; }
        private List<EntitiesLayer.Character> Personnages { get; set; }

        public DalManager()
        {
            Teams = new List<EntitiesLayer.Team>();
            Spells = new List<EntitiesLayer.Spell>();
            Fights = new List<EntitiesLayer.Fight>();
            Personnages = new List<EntitiesLayer.Character>();
            DalSQLServer = new DalSQLServer();
        }

        public static DalManager Instance
        {
            get
            {
                if(_instance==null)
                {
                    lock (padlock)
                    {
                        if(_instance==null)
                        {
                            _instance = new DalManager();
                        }
                    }
                }
                return _instance;
            }
        }

        public IDal IDal
        {
            get => default(IDal);
            set
            {
            }
        }

        public DalSQLServer DalSQLServer { get; set; }

        public List<EntitiesLayer.Character> GetCharacters()
        {
            Personnages = DalSQLServer.GetCharacters();
            return Personnages;
        }
        public EntitiesLayer.Character GetCharacter(string name)
        {
            return DalSQLServer.GetCharacter(name);
        }
        public EntitiesLayer.Character GetCharacter(int Id)
        {
            return DalSQLServer.GetCharacter(Id);
        }

        public List<EntitiesLayer.Team> GetTeams()
        {
            Teams = DalSQLServer.GetTeams();
            return Teams;
        }
    }
}
