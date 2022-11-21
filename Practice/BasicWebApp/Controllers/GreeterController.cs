 using Microsoft.AspNetCore.Mvc;
 namespace BasicWebApp.Controllers;

//http://localhost:5000/Greeter/Greet/Nilesh
public class GreeterController : Controller
{
    public IActionResult Greet(int p , int r , int n , [FromServices] Services.ICounter counter)
    {
        ViewBag.Calculateemi = counter.SimpleInterest(p,r,n);
       
        return View("Result");
    }
}