using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers;

public class HomeController : Controller
{
    public ViewResult Index()
    {
        var hour = DateTime.Now.Hour;

        var viewModel = hour < 12 ? "Good morning" : "Good afternoon";

        return View("MyView", viewModel);
    }
}
