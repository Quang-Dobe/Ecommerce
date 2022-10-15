using SharedView.Enums;

namespace SharedView.Model
{
    public class Order
    {
        public int id { get; set; }

        public int customerId { get; set; }

        public List<Product> product { get; set; }

        public double total { get; set; }
    }
}
