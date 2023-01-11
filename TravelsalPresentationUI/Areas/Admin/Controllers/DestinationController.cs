using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TravelsalPresentationUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
