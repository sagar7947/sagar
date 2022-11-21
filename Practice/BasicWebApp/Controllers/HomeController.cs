using Microsoft.AspNetCore.Mvc;
namespace BasicWebApp.Controllers;
//http://localhost:5000/
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View("Finance");
    }
}
