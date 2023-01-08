using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TravelsalPresentationUI.Areas.Member.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
