using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace ModelMVVM
{
    class MyViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void onPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public ObservableCollection<Zapis> Zapisi { get; set; }
        public string Naslov { get; set; }
        private Zapis trenutni { get; set; }
        public Zapis Trenutni
        {
            get { return trenutni; }
            set { trenutni = value;
                NarediZeleno.RaiseCanExecuteChanged();
            }
        }

        public DelegateCommand NarediZeleno { get; private set; }

        public MyViewModel()
        {
            Zapisi = new ObservableCollection<Zapis>();
            for (int k=0;k<10;k++)
            {
                Zapisi.Add(new Zapis { Ime = k.ToString(), Barva = Windows.UI.Color.FromArgb(255, 123, 213, 125) });
            }
            Naslov = "Moj zap";
            NarediZeleno = new DelegateCommand
            (
                (p) => { Trenutni.Barva = Windows.UI.Color.FromArgb(255, 255, 255, 255); },
                (p) => { return Trenutni == null; }
            );
            Trenutni = Zapisi.First();
            
        }
    }
}
