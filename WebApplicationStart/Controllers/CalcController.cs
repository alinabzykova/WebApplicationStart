using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    [Route("calc")]
    public class CalcController : Controller
    {
        [HttpGet("index")]
        public string Index(double a = 0, double b = 0, string c = "+")
        {
            double result = 0;

            if (c == "+")
            {
                result = a + b;
            }
            else if (c == "-")
            {
                result = a - b;
            }
            else if (c == "*")
            {
                result = a * b;
            }
            else if (c == "/")
            {
                if (b == 0)
                    return "Ошибка: деление на ноль невозможно";

                result = a / b;
            }
            else
            {
                return "Ошибка: используйте операции +, -, * или /";
            }

            return $"{a} {c} {b} = {result}";
        }
    }
}