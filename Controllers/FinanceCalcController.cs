using Microsoft.AspNetCore.Mvc;

namespace SmartLife_Calculator.Controllers
{
    public class FinanceCalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
