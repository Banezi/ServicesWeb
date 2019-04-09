using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialisationXML
{
    [SerializableAttribute]
    public class Homme
    {
        public string Nom;
        public string Prenom;

        public Homme(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }
        public Homme()
        {
            Nom ="";
            Prenom = "";
        }
    }
}
