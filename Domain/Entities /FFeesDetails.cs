
﻿using Domain.AuditableEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class FFeesDetails : AuditEntities
    {
        [Key]
        public int FranchiseFeesDetailsId { get; set; }
        public DateTime? month { get; set; }
        public decimal? payableFee { get; set; }
        public decimal? royalityFee { get; set; }
        public decimal? expenses { get; set; }
        public decimal? PaidAmount { get; set; }
       
    }
}
