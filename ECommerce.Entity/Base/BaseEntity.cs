using ECommerce.Entity.Enum;
using ECommerce.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity.Base
{
    public abstract class BaseEntity : IEntity<Guid>
    {
        public BaseEntity()
        {
            IsActive = true;
            Status =Status.Created;
            CreatedDate = DateTime.Now;
            MaseterId = Guid.NewGuid();
        }

        public int Id { get; set; }
        //Eğer primary key propert adı Id yerine farklı bir isimli ile adlandırılmışsa o halde iligili propertnin üzerine [key] tanımlanmalıdır.
        public Guid MaseterId { get; set; }

        //Created
        public DateTime CreatedDate { get; set; }
        [StringLength(255)]//Opsiyoenel olduğunu ifade ediyor.
        public string? CreatedComputerName { get; set; }
        [StringLength(255)]
        public string? CreatedAdUserame { get; set; }
        [StringLength(255)]
        public string? CreatedIpAddress { get; set; }

        //Updated
        public DateTime UpdatedDate { get; set; }
        [StringLength(255)]
        public string? UpdatedComputerName { get; set; }
        [StringLength(255)]
        public string? UpdatedAdUserame { get; set; }
        [StringLength(255)]
        public string? UpdatedIpAddress { get; set; }
        public bool IsActive { get; set; }
        public Status Status { get; set; }
    }
}
