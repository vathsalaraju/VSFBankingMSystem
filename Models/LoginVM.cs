using System.ComponentModel.DataAnnotations;

namespace BankingManagementSystem.Models
{
    public class LoginVM
    {
        [Key]
        public string UserId { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
