using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataContext_MVVM
{
    public class FicheClientViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string str = "")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(str));
            }
        }

        private ObservableCollection<Client> fiches;

        public ObservableCollection<Client> Fiches
        {
            get => fiches;
            set
            {
                if(value != fiches)
                {
                    fiches = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private Client ficheSelectionnee;

        public Client FicheSelectionnee
        {
            get { return ficheSelectionnee; }
            set
            {
                ficheSelectionnee = value;
                NotifyPropertyChanged();
            }
        }

        public FicheClientViewModel()
        {
            Fiches = new ObservableCollection<Client>();

            FicheSelectionnee = new Client()
            {
                Nom = "Dupont",
                Prenom = "Pierre",
                Age = 32,
                Sexe = "M"
            };

            Fiches.Add(FicheSelectionnee);
        }
    }
}
