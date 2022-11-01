using Microsoft.AspNetCore.Mvc;

namespace TravelsalPresentationUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
