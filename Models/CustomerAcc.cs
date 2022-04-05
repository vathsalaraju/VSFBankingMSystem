using System;
using System.Collections.Generic;

namespace VSFB.Models
{
    public partial class CustomerAcc
    {
        public CustomerAcc()
        {
            RegisterNetBankings = new HashSet<RegisterNetBanking>();
            TransactionDetails = new HashSet<TransactionDetail>();
        }

        public decimal AccountNumber { get; set; }
        public string? Status { get; set; }
        public string? CustomerId { get; set; }
        public decimal? Balance { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual ICollection<RegisterNetBanking> RegisterNetBankings { get; set; }
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
    }
}
