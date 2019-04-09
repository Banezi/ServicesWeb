using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Character : EntityObject
    {
        public string Name { get; set; }
        public int PvMax { get; set; }
        public int Pv { get; set; }
        public int Power { get; set; }
        public int Speed { get; set; }
        public Alliances Alliance { get; set; }
        public List<Spell> Spells { get; set; }
       
        public Character(string nm = "Dobby", int pv = 1, int pow = 1, int speed = 1)
        {
            Name = nm;
            PvMax = pv;
            Pv = pv;
            Power = pow;
            Speed = speed;
            Spells = new List<Spell>();
        }

        public void modLife(int val)
        {
            Pv += val;

            if (Pv > PvMax) Pv = PvMax;
        }
        
        public void addSpell(Spell s)
        {
            int i = 0;
            while (i < Spells.Count && Spells[i].ID != s.ID)
            {
                i++;
            }
            if (i == Spells.Count)
            { Spells.Add(s); }
        }

        public void levelUp(int upPv, int upPower, int upSpeed)
        {
            PvMax += upPv;
            Power += upPower;
            Speed += upSpeed;
        }
        public Spell getSpellByName(string nm)
        {
            int i = 0;
            while (i < Spells.Count && Spells[i].Name != nm)
            {
                i++;
            }
            if (i == Spells.Count)
            { return Spell.NULL_SPELL; }
            else
            { return Spells[i]; }
        }
        public Spell getSpellById(int id)
        {
            int i = 0;
            while (i < Spells.Count && Spells[i].ID != id)
            {
                i++;
            }
            if (i == Spells.Count)
            { return Spell.NULL_SPELL; }
            else
            { return Spells[i]; }
        }

        public override string ToString()
        {
            return Name + " : PV( " + Pv + " / " + PvMax + " )";
        }
    }
}
