using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Character : EntityObject
    {
        private int _bravoury;
        private int _crazyness;
        private string _firstName;
        private string _lastName;
        private int _pv;
        private RelationshipEnum _relationships; //Rélations entre les personnages

        public int Bravoury { get => _bravoury; set => _bravoury = value; }
        public int Crazyness { get => _crazyness; set => _crazyness = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Pv { get => _pv; set => _pv = value; }
        private RelationshipEnum Relationships { get => _relationships; set => _relationships = value; }

        enum RelationshipEnum { FRIENDSHIP, LOVE, HARTED, RIVALRY }
        enum CharacterTypeEnum { WARRIOR, WITCH, TACTICIAN, LEADER, LOSER }
        void AddRelatives()
        {

        }
        Character(string prenom, string nom)
        {
            FirstName = prenom;
            LastName = nom;

        }
        string ToString()
        {
            return ("First Name : " + _firstName + " Last Name : " + _lastName + " Bravoury : " + _bravoury + " Crazyness : " + _crazyness + " Pv : " + _pv);
        }
    }
}
