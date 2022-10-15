using SharedView.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedView.Model
{
    public class Order
    {
        public int orderId { get; set; }

        public int customerId { get; set; }

        public DateTime dateOfPurchase { get; set; }

        public double total { get; set; }
    }
}
