using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Drawing;

namespace ModelMVVM
{
    class Zapis:INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        private Windows.UI.Color barva;
        public Windows.UI.Color Barva
        {
            get { return barva; }
            set { barva = value; }
        }
        public void onPropertyChanged([CallerMemberName] string propertyName=null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler!=null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
