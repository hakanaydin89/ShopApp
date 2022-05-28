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
                }

                context.SaveChanges();
            }
        }

        private static Category[] Categories =
        {
            new Category() {Name="Telefon"},
            new Category() {Name="Bilgisayar"},
        };

        private static Product[] Products =
        {
            new Product() {Name="Samsung S9",ImageUrl="1.jpg",Price=1000},
                new Product() {Name="Samsung S10",ImageUrl="2.jpg",Price=2000},
                new Product() {Name="Samsung S11",ImageUrl="3.jpg",Price=3000},
                new Product() {Name="Samsung S12",ImageUrl="4.jpg",Price=4000},
                new Product() {Name="IPhone 10",ImageUrl="5.jpg",Price=5000},
                new Product() {Name="IPhone 11",ImageUrl="6.jpg",Price=6000},
                new Product() {Name="IPhone 12",ImageUrl="7.jpg",Price=7000},
                
        };
    }
}
