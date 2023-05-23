// using Microsoft.AspNetCore.Mvc;
// using LanguageFeatures.Models;
// Above are no longer needed because GlobalUsing.cs clas defines the 
// common using statements related to each class.

namespace LanguageFeatures.Controllers {
    public class HomeController : Controller {
    public ViewResult Index() {
        Product?[] products = Product.GetProducts();

        ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

        decimal cartTotal = cart.FilterByPrice(100).TotalPrices(); // Usage of extension methods; chaining

        return View(new string[] { $"Total: {cartTotal:c2}" });

        bool byPrice(Product? product) {
            return product?.Price >= 20;
        }

        var cartFilterResult = cart.Filter(byPrice); // Calling using the lambda

        // Dictionary<string, Product> productAll = new() { // New dictionary using target type initialisation
        //     ["Kayak"] = new Product { Name = "Kayak", Price = 782m },
        //     ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 232m }
        // };

        // object[] somePatterns = new string[] { "a", "1", "78.24" };

        // foreach (var i in somePatterns) { // Pattern matching; in this case all decimals are picked up for processing
        //     if (i is decimal toPrint) {

        //     }
        // }

        // return View(productAll.Keys);

        // return View(new string[] { "Alice", "Bob" }); // Collection initialiser

        // return View (new string[] { $"Name: {products[0]?.Name}, Price: {products[0]!.Price:C2}" }); // string interpolation

        // return View(new string[] {  products[0]?.Name ?? "No value" }); // Null coalescing

        // return View(new string[] { products[0]!.Name }); // Null forgiving operator
    
     }
    }
}