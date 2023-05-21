using ECommerce.DAL.Seed;
using ECommerce.Entity.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Contex
{
    public class EcommersContext:IdentityDbContext
    {

        //Tables
        public DbSet<Category> Categories { get; set; }

        public  DbSet<Product> Products { get; set; }

        public DbSet<Supplier> suppliers { get; set; }

        //FakeaData
        protected override void OnModelCreating(ModelBuilder builder)
        {

            //Category 
            builder.Entity<Category>().HasData(CategorySeed.Categories);//Hasdata categoty tipinde bir list bekliyor.

            //Product
            builder.Entity<Product>().HasData(ProductSeed.products);

            //Supplier
            builder.Entity<Supplier>().HasData(SupplierSeed.suppliers);

            base.OnModelCreating(builder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=PEACE\\BARIS;Database=Ecommerce;User Id=sa;Password=1234;");
            }//Biz injector yapısını uı taraflı yapıtpımız için uı mız yok şuan o yüzden burda oluşturduk.
        }
    }
}
