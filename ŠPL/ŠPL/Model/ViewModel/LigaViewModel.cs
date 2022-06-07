using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŠPL.Model.ViewModel
{
    class LigaViewModel
    {
        public EkipaViewModel Ekipa1 { get; set; }
        public EkipaViewModel Ekipa2 { get; set; }
        public LigaViewModel()
        {
            Ekipa e1 = new Ekipa("1", dobiIg1());
            Ekipa1 = new EkipaViewModel(e1);
            Ekipa e2 = new Ekipa("2", dobiIg2());
            Ekipa2 = new EkipaViewModel(e2);
        }

        private IEnumerable<Igralec> dobiIg2()
        {
            List<Igralec> i = new List<Igralec>() {
            new Igralec("jj", true, 69),
            new Igralec("jj", true, 69),
            new Igralec("jj", true, 69),
            new Igralec("jj", true, 69),
            new Igralec("jj", true, 69),
            new Igralec("jj", true, 69),
            new Igralec("jj", true, 69),
            new Igralec("jj", true, 69),
            new Igralec("jj", true, 69),
            new Igralec("jj", false, 69),
            new Igralec("jj", false, 69)
        };
            return i;
        }

        private IEnumerable<Igralec> dobiIg1()
        {
            List<Igralec> i = new List<Igralec>() {
            new Igralec("gg", true, 420),
            new Igralec("gg", true, 420),
            new Igralec("gg", true, 420),
            new Igralec("gg", true, 420),
            new Igralec("gg", true, 420),
            new Igralec("gg", true, 420),
            new Igralec("gg", true, 420),
            new Igralec("gg", true, 420),
            new Igralec("gg", true, 420),
            new Igralec("gg", false, 420),
            new Igralec("gg", false, 420),

        };
            return i;
        }
    }
}
