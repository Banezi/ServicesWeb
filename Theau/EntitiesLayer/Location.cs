using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public enum Alliances {
        UNDEFINED,
        NINTENDOR,
        PECERDAIGLE,
        PLAYSTESHOUFLE,
        XBOXARD
    }
    public class Location : EntityObject
    {
        public string Name { get; set; }
        public Alliances Alliance { get;set; }
        public int BuffPower { get; set; }
        public int BuffSpeed { get; set; }

        public Location(string nm, Alliances all, int bp, int bs)
        {
            Name = nm;
            Alliance = all;
            BuffPower = bp;
            BuffSpeed = bs;
        }
    }
}
