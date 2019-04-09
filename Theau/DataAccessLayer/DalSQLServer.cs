using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;

namespace DataAccessLayer
{
    public class DalSQLServer : IDal
    {
        public EntitiesLayer.Character GetCharacters(Character c)
        {
            EntitiesLayer.Character nc = new EntitiesLayer.Character();

            nc.ID = c.Id;
            nc.Name = c.Name;
            nc.Pv = c.PV ?? default(int);
            nc.Power = c.Power ?? default (int);
            nc.Speed = c.Speed ?? default(int);
            //nc.Type = (int)c.Type;

            return nc;
        }
        public EntitiesLayer.Character GetCharacter(string name)
        {
            DataAccessLayer.GeniusDBEntities db = new GeniusDBEntities();
            Character DBc = db.Character.FirstOrDefault(f => f.Name == name);

            return (new EntitiesLayer.Character(DBc.Name, DBc.PV, DBc.Power, DBc.Speed));
        }
        public EntitiesLayer.Character GetCharacter(int Id)
        {
            DataAccessLayer.GeniusDBEntities db = new GeniusDBEntities();
            Character DBc = db.Character.FirstOrDefault(f => f.Id == Id);

            return (new EntitiesLayer.Character(DBc.Name, DBc.PV, DBc.Power, DBc.Speed));
        }

        // sinon public override en cas d'une classe abstraite pour Idal
        public List<EntitiesLayer.Character> GetCharacters()
        {
            List<EntitiesLayer.Character> list = new List<EntitiesLayer.Character>();
            DataAccessLayer.GeniusDBEntities db = new GeniusDBEntities();

            var query = db.Character;

            foreach (Character c in query)
            {
                list.Add(GetCharacters(c));
            }
            return list;
        }

        public void AddCharacter(EntitiesLayer.Character c)
        {
            DataAccessLayer.GeniusDBEntities db = new GeniusDBEntities();
            Character DBc = new Character();
            DBc.Name = c.Name;
            DBc.Id = c.ID;
            DBc.Speed = c.Speed;
            DBc.Power = c.Power;
            DBc.PV = c.Pv;
            //DBc.Type = c.Type;

            db.Character.Add(DBc);
            db.SaveChanges();
        }

        public void UpdateCharacter(EntitiesLayer.Character c)
        {
            DataAccessLayer.GeniusDBEntities db = new GeniusDBEntities();
            Character DBc = db.Character.FirstOrDefault(f => f.Id == c.ID);

            DBc.Name = c.Name;
            DBc.Id = c.ID;
            DBc.Speed = c.Speed;
            DBc.Power = c.Power;
            DBc.PV = c.Pv;
            //DBc.Type = c.Type;

            db.SaveChanges();
        }

        public List<EntitiesLayer.Team> GetTeams()
        {
            List<EntitiesLayer.Team> list = new List<EntitiesLayer.Team>();
            DataAccessLayer.GeniusDBEntities db = new GeniusDBEntities();

            var query = db.Team;

            foreach (Team t in query)
            {
                list.Add(GetTeam(t));
            }
            return list;
        }

        public EntitiesLayer.Team GetTeam(Team t)
        {
            EntitiesLayer.Team nc = new EntitiesLayer.Team();
            nc.ID = t.ID;
            nc.Alliance = t.Alliance;
            nc.Teammates = t.Teammates;
            return nc;
        }
    }
}
