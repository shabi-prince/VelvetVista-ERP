
﻿using Domain.AuditableEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class FContract : AuditEntities
    {
        [Key]
        public int FranchiseContractId { get; set; }
        //public int? FranchiseId { get; set; }
        public int? ContractTypeId { get; set; }
        public decimal? InititalInvestment { get; set; }
        public decimal? Rent { get; set; }
        public bool? PartyFlag { get; set; }
        public virtual ContractType ContractType { get; set; }        
       
    }
}
