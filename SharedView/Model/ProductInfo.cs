using System.ComponentModel.DataAnnotations;

namespace SharedView.Model
{
    public class ProductInfo
    {
        [Key]
        public int id { get; set; }

        public int inventoryNumber { get; set; }

        public double rating { get; set; }
    }
}
