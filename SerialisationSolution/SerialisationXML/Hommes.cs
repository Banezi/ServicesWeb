using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialisationXML
{
    [SerializableAttribute]
    public class Hommes : System.Collections.CollectionBase
    {
        public void Add(Homme HommeA)
        {
            this.List.Add(HommeA);
        }

        public Homme this[int index]
        {
            get { return (Homme)this.List[index]; }
        }
    }
}
