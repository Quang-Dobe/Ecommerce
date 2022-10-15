using SharedView.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedView.Model
{
    public class OrderDetail
    {
        public CustomerAccount accountId { get; set; }

        public Product productId { get; set; }

        public Order orderId { get; set; }

        [Column("Number of product")]
        public int number { get; set; }

        public ProductRating rating { get; set; }
    }
}
