using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OC_WPF_Binding
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button MonSecondBouton;
        /* Pour créer son propre evenement : il faut créer un delegate : type de méthode qui sera appelée lorsque l'evenement 
         * se produit.
         */
        delegate void MonPremierDelegate(string str);
        event MonPremierDelegate MonPremierEvenement;

        public MainWindow()
        {
            InitializeComponent();
            //Test sur le binding
            /*
            //Thread.Sleep(20000); // N'a pas l'air de fonctionner
            MonPremierLabel.Content = "Contenu modifié";
            //Thread.Sleep(20000);
            MonSecondLabel.Content = "Contenu modifié une seconde fois";
            */
            // Création et ajout d'un bouton et son evenement depuis le code C#
            MonSecondBouton = new Button();
            MonSecondBouton.Content = "Mon Second Bouton";
            MonSecondBouton.Click += MonSecondBouton_Click;
            MonPremierStackPanel.Children.Add(MonSecondBouton);

            //Abonnement d'une méthode à l'evenement sans méthode anonyme (lambda)
            //MonPremierEvenement += CeciEstUneMethode;
            //Abonnement d'une méthode à l'evenement avec méthode anonyme (lambda)
            string toto = " Toto";
            MonPremierEvenement += (str) =>
            {
                //Même contenu que la méthode CeciEstUneMethode
                //MonPremierLabel.Content = str;
                MonPremierLabel.Content = str + toto; //NB : on peut utiliser des variables definies plus haut dans notre lambda
            };
        }

        private void MonSecondBouton_Click(object sender, RoutedEventArgs e)
        {
            //MonPremierLabel.Content = DateTime.Now.Second;
            //Lancement de l'evenement MonPremierEvenement
            MonPremierEvenement("Second Bouton Cliqué");
        }

        private void MonPremierBouton_Click(object sender, RoutedEventArgs e)
        {
            //MonPremierLabel.Content = DateTime.Now;
            //Lancement de l'evenement MonPremierEvenement
            MonPremierEvenement("Premier Bouton Cliqué");
        }

        private void CeciEstUneMethode(string str)
        {
            MonPremierLabel.Content = str;
        }
    }
}
