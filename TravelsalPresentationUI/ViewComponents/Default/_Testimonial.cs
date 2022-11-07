using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TravelsalPresentationUI.ViewComponents.Default
{
    public class _Testimonial : ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public _Testimonial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _testimonialService.GetList();
            return View(values);
        }
    }
}
