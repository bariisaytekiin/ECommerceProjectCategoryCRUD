using ECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Seed
{
    internal class CategorySeed
    {

        public static List<Category> Categories = new List<Category>()//Contexe aktarsın diye static Fake datalarımız
        {
            new Category(){Id=1,CategoryName="Giyim",Description="yAzlık giyim"},
            new Category(){Id=2,CategoryName="Tekboloji",Description="telefon "},
            new Category(){Id=3,CategoryName="Kozmatik",Description="parfüm "},
        };
    }
}
