using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Team : EntityObject
    {
        public List<Character> Teammates { get; set; }
        public Alliances Alliance { get; set; }
        public Team(Alliances a = Alliances.UNDEFINED)
        {
            Alliance = a;
        }
        
        public Team(List<Character> l)
        {
            if (l.Count > 0)
            {
                Teammates = l;
                Alliance = l[0].Alliance;
            }
        }
        public Team(Character c)
        {
            Teammates = new List<Character>();
            Teammates.Add(c);
            Alliance = c.Alliance;
        }

        // MODIF TEAMMATES LIST
        public void addTeammate(Character c)
        {
            if (Alliance == Alliances.UNDEFINED)
            {
                Alliance = c.Alliance;
            }

            if (c.Alliance == Alliance)
            {
                Teammates.Add(c);
            }
        }
        public void removeTeammate(Character c)
        {
            removeTeammate(c.ID);
        }
        public void removeTeammate(string name)
        {
            int i = 0;
            while (i > -1 && i < Teammates.Count)
            {
                if (Teammates[i].Name == name)
                {
                    Teammates.RemoveAt(i);
                    i = -1;
                }
                else i++;
            }
            checkAlliance();
        }
        public void removeTeammate(int id)
        {
            int i = 0;
            while (i > -1 && i < Teammates.Count)
            {
                if (Teammates[i].ID == id)
                {
                    Teammates.RemoveAt(i);
                    i = -1;
                }
                else i++;
            }
            checkAlliance();
        }
        public void checkAlliance()
        {
            if (Teammates.Count == 0)
            {
                Alliance = Alliances.UNDEFINED;
            }
        }
        public void clear()
        {
            Teammates.Clear();
            Alliance = Alliances.UNDEFINED;
        }

    }
}
