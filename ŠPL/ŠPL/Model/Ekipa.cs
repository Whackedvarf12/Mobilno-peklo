﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŠPL.Model
{
    class Ekipa
    {
        public string ImeEkipe { get; set; }
        public List<Igralec> Igralci { get; }
        public int Številka { get; set; }
        public Ekipa(string i, IEnumerable<Igralec> ig)
        {
            ImeEkipe = i;
            Igralci = new List<Igralec>();
            Igralci.AddRange(ig);
        }
    }
}
