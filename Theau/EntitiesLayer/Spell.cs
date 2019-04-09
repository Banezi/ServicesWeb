using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Spell : EntityObject
    {
        public string Name { get; set; }
        public int PowerReq { get; set; }
        public int Power { get; set; }

        public static readonly Spell NULL_SPELL = new Spell(0, 0);

        public Spell(int pr, int p)
        {
            PowerReq = pr;
            Power = p;
        }

        public void use(Character target)
        { 
            target.modLife(Power);
        }
    }
}
