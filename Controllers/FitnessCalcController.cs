using Microsoft.AspNetCore.Mvc;

namespace SmartLife_Calculator.Controllers
{
    public class FitnessCalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
