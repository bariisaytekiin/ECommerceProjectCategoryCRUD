using ECommerce.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity.Interface
{
    internal interface IEntity<T>//Bu yapı bizim istediğimiz ıd tipini belrlemek için kullanıyoruz.
    {

        public int Id { get; set; } //Güvenlik açısından idyi int olarak tanımlamak dejavantajlı.Bu ıd bizim kullnacağımız işlemlerde kullnamka için kullnaıyoruz.

        public T MaseterId { get; set; }//Vitrindeki ürünleri göstermek için kullanıcaz.

        //Created
        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedAdUserame { get; set; }
        public string CreatedIpAddress { get; set; }

        //Updated
        public DateTime UpdatedDate { get; set; }
        public string UpdatedComputerName { get; set; }
        public string UpdatedAdUserame { get; set; }
        public string UpdatedIpAddress { get; set; }

        //Active durumuru
        public bool IsActive { get; set; }
        public Status Status { get; set; }//
    }
}
