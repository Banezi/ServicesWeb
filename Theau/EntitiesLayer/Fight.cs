using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{

    public class Fight : EntityObject
    {
        public Team ATeam { get; set; }
        public Team BTeam { get; set; }
        public Location Locat { get; set; }

        public Fight(Location loc, List<Character> AT, List<Character> BT)
        {
            Locat = loc;
            ATeam = new Team(AT);
            BTeam = new Team(BT);
        }

        public void ChangeLocation(Location loc)
        {
            Locat = loc;
        }

        // CHANGE TEAM A
        public void NewATeam(Team t)
        {
            ATeam = t;
        }
        public void NewATeam(List<Character> list)
        {
            ATeam = new Team(list);
        }
        public void NewATeam(Character c)
        {
            ATeam = new Team(c);
        }
        // CHANGE TEAM B
        public void NewBTeam(Team t)
        {
            BTeam = t;
        }
        public void NewBTeam(List<Character> list)
        {
            BTeam = new Team(list);
        }
        public void NewBTeam(Character c)
        {
            BTeam = new Team(c);
        }
    }
}
