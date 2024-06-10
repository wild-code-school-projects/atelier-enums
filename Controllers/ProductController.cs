using EnumerationVue.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnumerationVue.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            var products = new List<Product>()
            {
                new Product
                {
                    Name = "iPhone 13 Pro",
                    Description = "The iPhone 13 Pro features a 6.1-inch Super Retina XDR display, A15 Bionic chip, triple-camera system with 12MP ultra-wide, wide, and telephoto lenses, and up to 1TB of storage. It offers 5G connectivity and improved battery life.",
                    Price = 1660.99M,
                    Category = Enums.ECategory.ELECTRONICS
                },

                new Product{
                    Name = "Samsung Galaxy S21",
                    Description = "The Samsung Galaxy S21 comes with a 6.2-inch Dynamic AMOLED display, Exynos 2100 processor, triple-camera setup, and 5G connectivity. It offers up to 256GB of storage and a sleek design.",
                    Price = 1199.99M,
                    Category = Enums.ECategory.ELECTRONICS
                },

                new Product{
                    Name = "Nike Dri-FIT Men's T-Shirt",
                    Description = "This lightweight and breathable t-shirt is made with Nike's Dri-FIT technology to keep you cool and dry during workouts. It features a comfortable fit and stylish design, available in various colors.",
                    Price = 60.99M,
                    Category = Enums.ECategory.FASHION
                },

                new Product{
                    Name = "Adidas Ultraboost Running Shoes",
                    Description = "These running shoes offer a responsive boost midsole, Primeknit upper for adaptive support, and a flexible outsole for superior grip. Perfect for running and everyday wear.",
                    Price = 180.00M,
                    Category = Enums.ECategory.FASHION
                },

                new Product{
                    Name = "Nerf Elite 2.0 Shockwave RD-15 Blaster",
                    Description = "This Nerf blaster features a 15-dart rotating drum, pump-action priming, and tactical rails for customization. It offers high-performance play for Nerf battles.",
                    Price = 50.30M,
                    Category = Enums.ECategory.GAMES
                },

                new Product{
                    Name = "LEGO Creator Expert Assembly Square",
                    Description = "A detailed and challenging LEGO set with over 4,000 pieces. It features a modular building with shops, a café, and apartments, perfect for advanced builders and collectors.",
                    Price = 299.99M,
                    Category = Enums.ECategory.GAMES
                },

                new Product{
                    Name = "Justin's Classic Almond Butter",
                    Description = "Made with only two ingredients, dry roasted almonds and palm oil, this almond butter is creamy and delicious. It’s perfect for spreading on toast, adding to smoothies, or using as a dip for fruits and vegetables.",
                    Price = 2.99M,
                    Category = Enums.ECategory.FOODS
                },

                new Product{
                    Name = "San Marzano Whole Peeled Tomatoes",
                    Description = "These authentic San Marzano tomatoes are grown in the volcanic soil of Italy and are known for their rich, sweet flavor. Perfect for making sauces, soups, and stews, they come in a 28-ounce can.",
                    Price = 3.99M,
                    Category = Enums.ECategory.FOODS
                },

                new Product{
                    Name = "Garmin Forerunner 945",
                    Description = "A high-performance GPS running watch with advanced training features, music storage, and comprehensive health monitoring. It includes built-in maps, Pulse Ox sensors, and up to 2 weeks of battery life in smartwatch mode.",
                    Price = 599.99M,
                    Category = Enums.ECategory.ELECTRONICS
                },

                new Product{
                    Name = "Michael Kors Jet Set Tote",
                    Description = "This stylish tote bag is crafted from Saffiano leather and features a spacious interior with multiple pockets. It has a top-zip closure, dual shoulder straps, and the iconic Michael Kors logo.",
                    Price = 298.00M,
                    Category = Enums.ECategory.FASHION
                },
            };

            return View(products);
        }
    }
}
