using EnumerationVue.Enums;
using System.Globalization;

namespace EnumerationVue.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ECategory Category { get; set; }

        public Product()
        {
            Id = Guid.NewGuid();
        }
    }
}
