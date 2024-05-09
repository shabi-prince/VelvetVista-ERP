using Domain.AuditableEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CompetitorStore : AuditEntities
    {
        [Key]
        public int CompetitorStoreId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string MapLocation { get; set; }
        public string DotColour { get; set; }
        public int? CompetitorId { get; set; }
       
        public virtual Competitor Competitor { get; set; }
    }
}
