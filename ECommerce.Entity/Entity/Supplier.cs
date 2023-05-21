using ECommerce.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity.Entity
{
    public class Supplier:BaseEntity
    {
        [Required]//Boş geçilemez
        [MaxLength(255)]//Max uzunluk
        public string CompanyName { get; set; }
        [Required]
        public string ContactName { get; set; }
        [Required]
        public string Phone { get; set; }

        public List<Product> Products { get; set; }

    }
}
