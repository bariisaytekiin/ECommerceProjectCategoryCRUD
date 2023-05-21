using ECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Seed
{
    internal class SupplierSeed
    {
        public static List<Supplier> suppliers = new List<Supplier>()
        {
            new Supplier(){Id=1,CompanyName="ABC AŞ",ContactName="Ali",Phone="12345"},
            new Supplier(){Id=2,CompanyName="DEF AŞ",ContactName="Veli",Phone="67890"},
            new Supplier(){Id=3,CompanyName="KLM AŞ",ContactName="Ahmet",Phone="35789"}
        };

    }
}
