using SharedView.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedView.Model
{
    public class OrderDetail
    {
        public int customerId { get; set; }

        public int productId { get; set; }

        [Column("Number of product")]
        public int number { get; set; }

        public ProductRating rating { get; set; }

        public string comment { get; set; }
    }
}
