using System.ComponentModel.DataAnnotations;

namespace SharedView.Model
{
    public class ProductSite
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Please fill in the required information")]
        public string country { get; set; }

        [Required(ErrorMessage = "Please fill in the required information")]
        public string companyName { get; set; }

        [Required(ErrorMessage = "Please fill in the required information")]
        public string address { get; set; }


        public int companyID { get; set; }
    }
}
