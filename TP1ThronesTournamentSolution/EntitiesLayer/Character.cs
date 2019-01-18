using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Character : EntityObject
    {
        public int Bravoury { get; set; }
        public int Crazyness { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Pv { get; set; }
        public RelationshipEnum[] Relationships { get; set; }
        public CharacterTypeEnum CharacterType { get; set; }

        public Character()
        {
            
        }

        public Character(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Character(string firstName, string lastName, int bravoury, int crazyness, int pv, RelationshipEnum[] relationships, CharacterTypeEnum characterType) : this(firstName, lastName)
        {
            Bravoury = bravoury;
            Crazyness = crazyness;
            Pv = pv;
            Relationships = relationships;
            CharacterType = characterType;
        }

        public void AddRelatives()
        {
            
        }

        public override string ToString()
        {
            return "FirstName : " + FirstName + " LastName : " + LastName + " Bravoury : " + Bravoury + " Crazyness : " + Crazyness + " Pv : " + Pv + " Relationships : " + Relationships;
        }
    }
}
