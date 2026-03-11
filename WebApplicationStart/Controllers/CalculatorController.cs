using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index(double a = 0, double b = 0)
        {
            double result = a + b;

            return Content($"{a} + {b} = {result}");
        }
    }
}