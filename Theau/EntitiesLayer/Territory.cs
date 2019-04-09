using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Territory : EntityObject
    {
        public TerritoryType TerritoryType;

        public Character Owner { get; set; }

        public Territory(TerritoryType territoryType, Character owner)
        {
            TerritoryType = territoryType;
            Owner = owner;
        }
    }
}
