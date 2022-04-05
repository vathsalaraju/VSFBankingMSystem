using System;
using System.Collections.Generic;

namespace VSFB.Models
{
    public partial class RegisterNetBanking
    {
        public decimal AccountNumber { get; set; }
        public decimal CustomerId { get; set; }
        public string? Passwordd { get; set; }
        public string? TransactionPassword { get; set; }

        public virtual CustomerAcc AccountNumberNavigation { get; set; } = null!;
    }
}
