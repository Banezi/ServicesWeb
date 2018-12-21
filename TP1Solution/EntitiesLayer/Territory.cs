using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Territory : EntityObject
    {
        //Champs
        //TerritoryType

        int Owner;
        enum TerritoryType { SEA, MOUNTAIN, LAND, DESSERT}
        Territory()
        {

        }
    }
}
