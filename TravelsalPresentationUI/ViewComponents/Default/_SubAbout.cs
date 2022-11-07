using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TravelsalPresentationUI.ViewComponents.Default
{
    public class _SubAbout : ViewComponent
    {
        private readonly ISubAboutService _subAboutService;

        public _SubAbout(ISubAboutService subAboutService)
        {
            _subAboutService = subAboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _subAboutService.GetList();
            return View(values);
        }
    }
}
