using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();

            if (context.Database.GetPendingMigrations().Count()==0)
            {
                if (context.Categories.Count()==0)
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategory);
                }

                context.SaveChanges();
            }
        }

        private static Category[] Categories =
        {
            new Category() {Name="Telefon"},
            new Category() {Name="Bilgisayar"},
            new Category() {Name="Elektronik"}
        };

        private static Product[] Products =
        {
            new Product() {Name="Samsung S9",ImageUrl="1.jpg",Price=1000,Description="<p>güzel telefon</p>"},
                new Product() {Name="Samsung S10",ImageUrl="2.jpg",Price=2000,Description="<p>güzel telefon</p>"},
                new Product() {Name="Samsung S11",ImageUrl="3.png",Price=3000,Description="<p>güzel telefon</p>"},
                new Product() {Name="Samsung S12",ImageUrl="4.jpg",Price=4000,Description="<p>güzel telefon</p>"},
                new Product() {Name="IPhone 10",ImageUrl="5.jpg",Price=5000,Description="<p>güzel telefon</p>"},
                new Product() {Name="IPhone 11",ImageUrl="6.jpg",Price=6000,Description="<p>güzel telefon</p>"},
                new Product() {Name="IPhone 12",ImageUrl="7.jpg",Price=7000,Description="<p>güzel telefon</p>"},
                
        };

        private static ProductCategory[] ProductCategory =
        {
            new ProductCategory() {Product=Products[0],Category=Categories[0]},
            new ProductCategory() {Product=Products[0],Category=Categories[2]},
            new ProductCategory() {Product=Products[1],Category=Categories[0]},
            new ProductCategory() {Product=Products[1],Category=Categories[1]},
            new ProductCategory() {Product=Products[2],Category=Categories[0]},
            new ProductCategory() {Product=Products[2],Category=Categories[2]},
            new ProductCategory() {Product=Products[3],Category=Categories[1]}
        };
    }
}
