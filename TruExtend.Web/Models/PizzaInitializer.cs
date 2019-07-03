using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace TruExtend.Web.Models
{
    public class PizzaInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PizzaDbContext>
    {
        protected override void Seed(PizzaDbContext context)
        {
            var toppings = new List<Topping>
            {
                new Topping {Id = 1, Name = "Ham"},
                new Topping {Id = 2, Name = "Pepperoni"},
                new Topping {Id = 3, Name = "Pineapple"},
                new Topping {Id = 4, Name = "Potatoes"},
                new Topping {Id = 5, Name = "Cabbage"}
            };

            toppings.ForEach(s=>context.Toppings.Add(s));
            context.SaveChanges();
            var pizzas = new List<Pizza>
            {
                new Pizza {Id=1,Name = "Hawaiian",Toppings = toppings.FindAll(t=>t.Name=="Ham" || t.Name=="Pineapple" ) },
                new Pizza {Id=2,Name = "Peperoni ",Toppings = toppings.FindAll(t=>t.Name=="Pepperoni")},
                new Pizza {Id=3,Name = "Irish ",Toppings = toppings.FindAll(t=>t.Name=="Potatoes"  || t.Name=="Cabbage" )}

            };
            pizzas.ForEach(s => context.Pizzas.Add(s));
            context.SaveChanges();
        }
    }
}