using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class House : EntityObject
    {
        public List<Character> Housers { get; set; }
        public string Name { get; set; }
        public int NumberOfUnities { get; set; }

        public House(string name)
        {
            Name = name;
        }
        public House(string name, List<Character> housers)
        {
            Name = name;
            Housers = housers;
        }

        public House(string name, int numberOfUnities)
        {
            Name = name;
            NumberOfUnities = numberOfUnities;
        }

        public void AddHousers(Character houser)
        {
            Housers.Add(houser);
        }
    }
}
