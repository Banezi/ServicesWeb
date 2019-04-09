using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerialisationXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Hommes _lesHommes = new Hommes();
            Homme h1 = new Homme("Bane", "Mamadou");
            Homme h2 = new Homme("Bane", "Moussa");
            _lesHommes.Add(h1);
            _lesHommes.Add(h2);
            //Sauvegarde
            /*
            StreamWriter stream = new StreamWriter(@"easyXML.net");

            XmlSerializer serializer = new XmlSerializer(typeof(Hommes));
            serializer.Serialize(stream, _lesHommes);
            stream.Close();
            */

            //Chargement
            /*
            XmlSerializer deserializer = new XmlSerializer(typeof(Hommes));

            StreamReader stream = new StreamReader(@"easyXML.net");
            Hommes _lesHommesDeserializer = (Hommes) deserializer.Deserialize(stream);
            stream.Close();

            Console.WriteLine(_lesHommesDeserializer.Count);
            Console.WriteLine(_lesHommesDeserializer[1].Prenom);
            */

            //Serialisation binaire
            //Sauvegarde
            /*
            FileStream mFile = new FileStream(@"easyBin.net", FileMode.Create);
            BinaryFormatter mS = new BinaryFormatter();
            mS.Serialize(mFile, _lesHommes);
            mFile.Close();
            */
            //Chargement
            FileStream mFile = new FileStream(@"easyBin.net", FileMode.Open);
            BinaryFormatter mS = new BinaryFormatter();
            Hommes _lesHommesBinairesDeserializer = (Hommes)mS.Deserialize(mFile);
            mFile.Close();
            Console.WriteLine(_lesHommesBinairesDeserializer.Count);
            Console.WriteLine(_lesHommesBinairesDeserializer[1].Prenom);
            Console.ReadLine();

        }
    }
}
