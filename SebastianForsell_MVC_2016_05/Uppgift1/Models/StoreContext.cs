using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1.Models
{
    public class StoreContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }
        public StoreContext() : base("MVCTenta201605")
        {
            Database.SetInitializer(new StoreInitializer());
        }
    }
    public class StoreInitializer : DropCreateDatabaseAlways<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var stores = new List<Store>
            {
                new Store
                {
                    Name = "Van Dykes Hardware", Address = "uitgartenstreet 2748", Products = new List<Product>
                    {
                        new Product {Name = "Bag of hammers",
                            ProductNumber = "p-9000", Price = 46.35,
                            productsInStock = 3672,
                            ProductText = "A big bag of disposable hammers." },
                        new Product {Name = "Chainsaw",
                            ProductNumber = "p-13", Price = 99.99,
                            productsInStock = 3,
                            ProductText = "This could be useful in a tight spot! Order yours today!" }
                    }
                },
                new Store
                {
                    Name = "Green House of Oranje", Address = "Grodingen", Products = new List<Product>
                    {
                        new Product {Name = "Smokey Dopey Bear",
                            ProductNumber = "p-356", Price = 7.35,
                            productsInStock = 9,
                            ProductText = "BEARS!" },
                        new Product {Name = "Jojo's Spicy Green",
                            ProductNumber = "p-261", Price = 5.0,
                            productsInStock = 127,
                            ProductText = "Real quality stuff rasta, real gud for dem brain." }
                    }
                }

            };
            foreach (var store in stores)
            {
                context.Stores.Add(store);
            }
            context.SaveChanges();
        }
    }
}
