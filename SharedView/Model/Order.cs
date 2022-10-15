using SharedView.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedView.Model
{
    public class Order
    {
        [Key]
        public int orderId { get; set; }

        public CustomerAccount accountId { get; set; }

        public DateTime dateOfPurchase { get; set; }

        public double total { get; set; }
    }
}
