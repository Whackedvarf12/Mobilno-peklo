using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemDva.Model
{

    public class Dijaki
    {
        public Dijak[] dijaki { get; set; }
    }

    public class Dijak
    {
        public string id { get; set; }
        public int DijID { get; set; }
        public string DijIme { get; set; }
        public string DijPriimek { get; set; }
    }

}
