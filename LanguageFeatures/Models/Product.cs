namespace LanguageFeatures.Models {

    public class Product {

        // Note that properties are normally non-nullable unless explicitly marked 
        // nullable wit ? symbol (e.g., string?)
        public string Name { get; set; } = string.Empty; // Always assigned a default value
        public decimal? Price { get; set; }

        public static Product?[] GetProducts() {

            Product kayak = new Product {
                Name = "Kayak",
                Price = 275M
            };

            Product lifejacket = new Product {
                Name = "Lifejacket",
                Price = 48.95M
            };

            return new Product?[] { kayak, lifejacket, null }; // The ? indicates that the null is allowed
        }

    }


}