using ECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Seed
{
    internal class ProductSeed
    {
        public static List<Product> products = new List<Product>()
        {
            new Product { Id = 1,ProductName="nike air max",Description="yazlık sneaker",CategoryId=1,UnitPrice=2000,UnitInStock=50,SupplierId=1},
            new Product { Id = 2,ProductName="Lenovo",Description="Bilgisayar",CategoryId=2,UnitPrice=20000,UnitInStock=5,SupplierId=2},
            new Product { Id = 3,ProductName="Kenzo",Description="yazlık fresh koku",CategoryId=3,UnitPrice=1000,UnitInStock=10,SupplierId=3},
        };
    }
}
