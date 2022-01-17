using Microsoft.AspNetCore.Mvc;

namespace SignalRChat.Controllers
{
    public class MessengerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Chat()
        {
            return View();
        }
    }
}
