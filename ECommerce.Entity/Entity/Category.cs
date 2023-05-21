using ECommerce.Entity.Base;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Entity.Entity
{
    public class Category:BaseEntity
    {
        //Anatosuin 
        [Required]//Boş geçilemez
        [MaxLength(255)]//Max uzunluk
        public string CategoryName { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
        //Sınırlandırma yaptığımız için contex tarafında onmodelcreating içinde sınırlandırılmaları yapmıyoruz.

        //Map

        public List<Product> Products { get; set; }
    }
}
