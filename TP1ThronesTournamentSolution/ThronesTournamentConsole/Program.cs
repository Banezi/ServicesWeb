using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThronesTournamentConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================================================================================");
            Console.WriteLine("||                            Game Of Throne Tournament                                      ||");
            Console.WriteLine("===============================================================================================");
            Console.WriteLine("\n");
            Console.WriteLine("1 - Afficher la liste des maisons");
            Console.WriteLine("2 - Afficher la liste des maisons qui contiennent plus de 200 unités");
            Console.WriteLine("3 - Afficher la liste des personnages qui ont plus de 3 points de forces et plus de 50 points de vies");
            Console.WriteLine("4 - Afficher la liste des terrains\n");
            Console.WriteLine("Saisissez un chiffre contenu dans le menu : ");
            BusinessManager manager = new BusinessManager();
            string saisi = Console.ReadLine();
            int choix;
            if (!int.TryParse(saisi, out choix))
                Console.WriteLine("Vous n'avez pas saisi de chiffre!");
            switch(choix)
            {
                case 1 :
                    Console.WriteLine("Affichage de la liste des maisons : ");
                    var liste = manager.AfficherListeMaisons();
                    foreach (var elmt in liste)
                        Console.WriteLine(elmt.Name);
                    break;
                case 2 :
                    manager.AfficherListeMaisonsPlus200Unites();
                    break;
                case 3:
                    manager.AfficherListeTerrains();
                    break;
                case 4 :
                    manager.AfficherPersonnagesPlus3PtsForcePlus50PtsVies();
                    break;
                default:
                    Console.WriteLine("Vous n'avez pas choisit un nombre dans le menu");
                    break;
            }
            Console.ReadLine();
        }
    }
}
