using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace DataContext_MVVM
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    
        /* Utilisation de Command à la place
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var c = (this.DataContext as Client);
            c.Age = 0;
            c.Nom = "";
            c.Prenom = "";
            c.Sexe = "";
        }
        */
    }
}
