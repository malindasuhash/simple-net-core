// using Microsoft.AspNetCore.Mvc;
// using LanguageFeatures.Models;
// Above are no longer needed because GlobalUsing.cs clas defines the 
// common using statements related to each class.

namespace LanguageFeatures.Controllers {
    public class HomeController : Controller {
    public ViewResult Index() {
        Product[] products = Product.GetProducts();

        return View(new string[] { products[0].Name });
    }
    }
}