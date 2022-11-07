using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TravelsalPresentationUI.ViewComponents.Default
{
    public class _ImpressionImages : ViewComponent
    {
        private readonly IFeatureService _featureService;

        public _ImpressionImages(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _featureService.GetList();
            return View(value);
        }
    }
}
