using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŠPL.Model.ViewModel
{
    class IgralecViewModel
    {
        public string Ime { get; set; }
        public int Številka { get; }
        public IgralecViewModel(string i, int s)
        {
            Ime = i;
            Številka = s;
        }
    }
}
