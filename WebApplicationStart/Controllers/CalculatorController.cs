using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    [Route("calculator")]
    public class CalculatorController : Controller
    {
        [HttpGet("index/{a?}/{b?}/{op?}")]
        public string Index(double a = 0, double b = 0, string op = "+")
        {
            double result = 0;

            if (op == "+")
            {
                result = a + b;
            }
            else if (op == "-")
            {
                result = a - b;
            }
            else if (op == "*")
            {
                result = a * b;
            }
            else
            {
                return "Ошибка: используйте операции +, - или *";
            }

            return $"{a} {op} {b} = {result}";
        }
    }
}