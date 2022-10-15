using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace SharedView.Model
{
    public class CustomerAccount
    {
        [Key]
        public int accountID { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Please fill in the required information")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string email { get; set; }

        [Required(ErrorMessage = "Please fill in the required information")]
        public string password { get; set; }

        [Required(ErrorMessage = "Please fill in the required information")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public int phoneNumber { get; set; }

        [Required(ErrorMessage = "Please fill in the required information")]
        public DateTime dateOfBirth { get; set; }

        public Guid hashCode = Guid.NewGuid();
    }
}
