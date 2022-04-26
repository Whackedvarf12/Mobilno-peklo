using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Prodajalnica.Models;

namespace Prodajalnica.Data
{
    public class ProdContInit:DropCreateDatabaseIfModelChanges<ProdajalnicaContext>

    {
        protected override void Seed(ProdajalnicaContext context)
        {
            var produkti = new List<Product>()
            {
                new Product(){ Name="Kosmiči", Price=1, ActualCost=0.99M},
                new Product(){ Name="Čigumi", Price=1, ActualCost=0.99M},
                new Product(){ Name="Kokta", Price=1, ActualCost=0.99M}
            };
            foreach (var p in produkti)
            {
                context.Products.Add(p);
            }
            context.SaveChanges();
            var order = new Order { Customer = "Janez" };
            var od = new List<OrderDetail>()
            {
                new OrderDetail(){ Product=produkti[0], Quantity=2, Order=order },
                new OrderDetail(){ Product=produkti[1], Quantity=2, Order=order }
            };
            context.Orders.Add(order);
            foreach (var o in od)
            {
                context.OrderDetails.Add(o);
            }
            context.SaveChanges();
        }
    }
    
}