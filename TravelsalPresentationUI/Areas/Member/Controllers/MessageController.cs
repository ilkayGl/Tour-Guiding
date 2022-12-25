using Microsoft.AspNetCore.Mvc;

namespace TravelsalPresentationUI.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
