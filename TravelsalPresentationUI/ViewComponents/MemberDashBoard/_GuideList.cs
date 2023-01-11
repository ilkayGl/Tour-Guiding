using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TravelsalPresentationUI.ViewComponents.MemberDashBoard
{
    public class _GuideList : ViewComponent
    {
        private readonly IGuideService _guideService;
        private readonly UserManager<AppUser> _userManager;

        public _GuideList(IGuideService guideService, UserManager<AppUser> userManager)
        {
            _guideService = guideService;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var guideList = _guideService.GetList();
            return View(guideList);
        }
    }
}
