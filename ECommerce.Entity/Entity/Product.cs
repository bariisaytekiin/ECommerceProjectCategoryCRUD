using ECommerce.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity.Entity
{
    public class Product:BaseEntity
    {

        [Required]
        [MaxLength(255)]
        public string ProductName { get; set; } 
        public decimal UnitPrice { get; set; }
        public decimal UnitInStock { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        [MaxLength(255)]
        public string? ImagePath { get; set; }

        //İlişkiler Repostry Map

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }//Layout


        public int SupplierId { get; set; }

        public virtual Supplier Supplier { get; set; }





    }
}
