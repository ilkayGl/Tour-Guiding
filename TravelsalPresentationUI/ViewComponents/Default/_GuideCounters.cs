using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TravelsalPresentationUI.ViewComponents.Default
{
    public class _GuideCounters : ViewComponent
    {
        private readonly Context c = new();

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Destinations.Count();

            ViewBag.v2 = c.Guides.Count();

            return View();
        }
    }
}
