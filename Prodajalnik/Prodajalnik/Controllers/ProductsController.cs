using Prodajalnik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prodajalnik.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] p = new Product[]
        {
            new Product{ Id=1, Ime="Kosmičeva juha", Kategorije="hrana", Cena=1 },
            new Product{ Id=2, Ime="Kapitan Pasta", Kategorije="hrana", Cena=2 },
            new Product{ Id=3, Ime="Ravioli čokolino", Kategorije="hrana", Cena=3 }
        };
        public IEnumerable<Product> GetProducts()
        {
            return p;
        }
        public Product GetProduct(int id)
        {
            var produkt = p.Where(a => a.Id == id).FirstOrDefault();
            return produkt;
        }
    }
}
