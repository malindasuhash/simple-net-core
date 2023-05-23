namespace LanguageFeatures.Models {

    public static class MyExtensionMethods {

        public static decimal TotalPrices(this IEnumerable<Product?> products) { // Extension methods are defined in static classes

            decimal total = 0;

            foreach (Product? product in products) {
                total += product?.Price ?? 0;
            }

            return total;

        }

        public static IEnumerable<Product?> FilterByPrice(this IEnumerable<Product?> products, decimal minPrice) { // Filtering extension method

            foreach (var product in products) {
                if ((product?.Price ?? 0) >= minPrice) {
                    yield return product;
                }
            }

        }

        public static IEnumerable<Product?> Filter(this IEnumerable<Product?> products, Func<Product?, bool> selector) {

            foreach (Product? product in products) {
                if (selector(product)) {
                    yield return product;
                }
            }

        }

    }

}