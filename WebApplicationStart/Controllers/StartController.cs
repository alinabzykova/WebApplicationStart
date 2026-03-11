using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApplicationStart.Controllers
{
    public class StartController : Controller
    {
        public IActionResult Hello()
        {
            int hour = DateTime.Now.Hour;
            string greeting;

            if (hour >= 0 && hour <= 5)
                greeting = "Доброй ночи";
            else if (hour >= 6 && hour <= 11)
                greeting = "Доброе утро";
            else if (hour >= 12 && hour <= 17)
                greeting = "Добрый день";
            else
                greeting = "Добрый вечер";

            return Content(greeting);
        }
    }
}