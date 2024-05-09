
﻿using Domain.AuditableEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Competitor : AuditEntities
    {
        public Competitor()
        {
            CompetitorStores = new List<CompetitorStore>();
        }

        [Key]
        public int CompetitorId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Latitude { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal? Longitude { get; set; }        
        public DateTime? created_at { get; set; }
       
        public virtual ICollection<CompetitorStore> CompetitorStores { get; set; }
    }
}
