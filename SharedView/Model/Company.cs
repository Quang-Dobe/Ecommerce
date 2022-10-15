using System.ComponentModel.DataAnnotations;

namespace SharedView.Model
{
    public class Company
    {
        [Key]
        public int id { get; set; }

        public string companyName { get; set; }

        public List<Product> products { get; set; }
    }
}
