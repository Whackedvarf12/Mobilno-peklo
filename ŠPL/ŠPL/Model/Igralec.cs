using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŠPL.Model
{
    class Igralec
    {
        public string Ime { get; set; }
        public bool Starter { get; set; }
        public int Številka { get; set; }
        public Igralec(string i, bool s, int š)
        {
            Ime = i;
            Starter = s;
            Številka = š;
        }
    }
}
