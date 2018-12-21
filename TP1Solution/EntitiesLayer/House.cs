using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class House : EntityObject
    {
        List<Character> Housers;
        string Name;
        int NumberOfUnities;
        House(string nom)
        {
            Name = nom;
            NumberOfUnities = 0;
        }
        void AddHousers(Character nvoHouser)
        {
            Housers.Add(nvoHouser);
            NumberOfUnities++;
        }
    }
}
