using SharedView.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedView.Model
{
    public class Product
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Please fill in the required information")]
        [Range(1, 30, ErrorMessage = "Product's name must be between 1 and 30 characters")]
        [Column("Product's name")]
        public string productName { get; set; }

        [Required(ErrorMessage = "Please fill in the required information")]
        public string description { get; set; }

        [Required(ErrorMessage = "Please fill in the required information")]
        public ProductType productType { get; set; }

        [Required(ErrorMessage = "Please fill in the required information")]
        public int price { get; set; }

        [Required(ErrorMessage = "Please fill in the required information")]
        public int quantity { get; set; }

        public int inventoryNumber { get; set; }

        public double rating { get; set; }

        public ProductSite productSiteId { get; set; }


        public DateTime createdDate { get; set; }
        public DateTime updatedDate { get; set; }
    }
}
