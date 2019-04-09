using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class DALSQLServer
    {
        public DALSQLServer(string co)
        {

        }

        public EntitiesLayer.Character GetCharacters(Character c)
        {
            EntitiesLayer.Character nc = new EntitiesLayer.Character();
            

            nc.id = c.Id;
            nc.FirstName = c.FName;
            nc.LastName = c.LName;
            nc.Pv = (int) c.PV;
            nc.Bravoury = (int) c.Bravoury;
            nc.Crazyness = (int) c.Crazyness;
            nc.Type = (int) c.Type;

            return nc;
        }
        public List<EntitiesLayer.Character> GetCharacters()
        {
            List<EntitiesLayer.Character> list = new List<EntitiesLayer.Character>();
            DataAccessLayer.GeniusDBEntities db = new GeniusDBEntities();

            var query = db.Character;

            foreach( Character c in query )
            {
                list.Add(GetCharacters(c));
            }
            return list;
        }
        public void AddCharacter(EntitiesLayer.Character c)
        {
            DataAccessLayer.GeniusDBEntities db = new GeniusDBEntities();
            Character DBc = new Character();
            DBc.FName = c.FirstName;
            DBc.LName = c.LastName;
            DBc.Id = c.id;
            DBc.Bravoury = c.Bravoury;
            DBc.Crazyness = c.Crazyness;
            DBc.PV = c.Pv;
            DBc.Type = c.Type;

            db.Character.Add(DBc);
            db.SaveChanges();
        }
        public void UpdateCharacter(EntitiesLayer.Character c)
        {
            DataAccessLayer.GeniusDBEntities db = new GeniusDBEntities();
            Character DBc = db.Character.FirstOrDefault(f => Id == c.id);

            DBc.FName = c.FirstName;
            DBc.LName = c.LastName;
            DBc.Id = c.id;
            DBc.Bravoury = c.Bravoury;
            DBc.Crazyness = c.Crazyness;
            DBc.PV = c.Pv;
            DBc.Type = c.Type;

            db.SaveChanges();
        }

    }
}
