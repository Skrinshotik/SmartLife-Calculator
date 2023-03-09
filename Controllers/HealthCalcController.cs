using Microsoft.AspNetCore.Mvc;

namespace SmartLife_Calculator.Controllers
{
    public class HealthCalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
