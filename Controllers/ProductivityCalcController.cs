using Microsoft.AspNetCore.Mvc;

namespace SmartLife_Calculator.Controllers
{
    public class ProductivityCalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
