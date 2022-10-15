using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedView.Model
{
    public class Customer
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Please fill in the required information")]
        [Range(1, 20, ErrorMessage = "First name must be between 1 and 20 characters long")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Please fill in the required information")]
        [Range(1, 20, ErrorMessage = "Last name must be between 1 and 20 characters long")]
        public string lastName { get; set; }

        public string middleName { get; set; }

        // Reforeign key: Customer_accountID -> CustomerAccount_id
        public List<CustomerAccount> accountId { get; set; }

        public DateTime createdDate { get; set; }

        public DateTime updatedDate { get; set; }

        public string address { get; set; }

    }
}
