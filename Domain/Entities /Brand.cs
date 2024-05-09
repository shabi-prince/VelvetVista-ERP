using Domain.AuditableEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Brand : AuditEntities
    {
        [Key]
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ISONum { get; set; }
        public string Slogan { get; set; }
        public string LogoImg { get; set; }
    }
}
