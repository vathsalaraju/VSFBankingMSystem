using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VSFB.Models
{
    public partial class TransactionDetail
    {
        [Display(Name ="Transaction ID")]
        public string TransactionId { get; set; } = null!;

        [Display(Name ="Transaction Mode")]
        public string? TransactionType { get; set; }
        [Display(Name = "From Account Number")]
        public decimal? AccountNumber { get; set; }
        [Display(Name = "Receiver's Account Number")]
        public decimal? ToAccountNumber { get; set; }
        
        public string? Maturityinstruct { get; set; }
        [Display(Name = "Transaction Date")]
        public DateTime? TransactionDate { get; set; }
        [Display(Name = "Transaction Type")]
        public string? DebitCredit { get; set; }

        public virtual CustomerAcc? AccountNumberNavigation { get; set; }
    }
}
