using Microsoft.AspNetCore.Mvc;

namespace SmartLife_Calculator.Controllers
{
    public class SecurityCalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
