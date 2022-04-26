using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prodajalnik.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Kategorije { get; set; }
        public decimal Cena { get; set; }

    }
}