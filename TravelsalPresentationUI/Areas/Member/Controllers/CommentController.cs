using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TravelsalPresentationUI.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    [Authorize]
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
