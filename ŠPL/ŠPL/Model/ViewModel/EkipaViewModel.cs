using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using ŠPL.Model;

namespace ŠPL.Model.ViewModel
{
    class EkipaViewModel:INotifyPropertyChanged
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
        public ObservableCollection<IgralecViewModel> Starters { get; set; }
        public ObservableCollection<IgralecViewModel> Klop { get; set; }
        private string imeEkipe;
        public string ImeEkipe
        {
            get { return imeEkipe; }
            set
            {
                imeEkipe = value;
                onPropertyChanged();
            }
        }
        private Ekipa ekipa;
        public EkipaViewModel(Ekipa e) {
            ekipa = e;
            Starters = new ObservableCollection<IgralecViewModel>();
            Klop = new ObservableCollection<IgralecViewModel>();
            ImeEkipe = e.ImeEkipe;
            posodobiEkipe();
        }
        public void posodobiEkipe()
        {
            var začetni=from x in ekipa.Igralci where x.Starter==true select x;
            Starters.Clear();
            foreach(var a in začetni)
            {
                IgralecViewModel b = new IgralecViewModel(a.Ime, a.Številka);
                Starters.Add(b);
            }
            var klop = from x in ekipa.Igralci where x.Starter == true select x;
            Starters.Clear();
            foreach (var a in klop)
            {
                IgralecViewModel b = new IgralecViewModel(a.Ime, a.Številka);
                Klop.Add(b);
            }
        }

    }
}
