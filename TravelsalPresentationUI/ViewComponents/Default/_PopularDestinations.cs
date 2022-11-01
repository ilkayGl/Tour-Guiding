using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TravelsalPresentationUI.ViewComponents.Default
{
    public class _PopularDestinations : ViewComponent
    {
        private readonly IDestinationService _DS;

        public _PopularDestinations(IDestinationService dS)
        {
            _DS = dS;
        }

        public IViewComponentResult Invoke()
        {
            var values = _DS.GetList();
            return View(values);
        }
    }
}
