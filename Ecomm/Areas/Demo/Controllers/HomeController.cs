using Microsoft.AspNetCore.Mvc;
using Ecommerce.Areas.Demo.ViewModels;


namespace Ecommerce.Areas.Demo.Controllers
{
    public class HomeController : Controller
    {
        // HTTP GET https://localhost:xxxx/Demo/Home/Index
        // ROUTE: url / {area} / {controller} / {action}
        public IActionResult Index()
        {
            return Ok("Hello world");
        }
        // HTTP GET https://localhost:xxxx/Demo/Home/Index2
        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult DisplayCustomer()
        {
            EmpolyeeViewModel viewModel = new EmpolyeeViewModel();


            return View(viewModel);
        }

        // To address over-posting ensure that the [Bind] attribute lists all the needed properties.
        // NOTE: the names of the properties is CASE-SENSITIVE.
        // HTTP POST
        //[HttpPost]
        //[ValidateAntiForgeryToken]                      // to address JavaScript Injection Attacks
        //public IActionResult DisplayCustomer(
        //    [Bind("CustomerId,CustomerName,Email,Balance")] EmpolyeeViewModel viewModel)
        //{
        //    return View(viewModel);
        //}
    }
}
