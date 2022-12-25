using AspNetCoreHero.ToastNotification.Abstractions;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TravelsalPresentationUI.Models;

namespace TravelsalPresentationUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly INotyfService _notyfService;

        public LoginController(UserManager<AppUser> userManager, INotyfService notyfService, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _notyfService = notyfService;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SingUp()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SingUp(UserRegisterViewModel p)
        {
            AppUser appUser = new AppUser()
            {
                Name = p.Name,
                Surname = p.Surname,
                Email = p.Mail,
                UserName = p.UserName
            };
            if (p.Password == p.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser, p.Password);
                if (result.Succeeded)
                {
                    RedirectToAction("SingIn", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                        //_notyfService.Error("Kayıt Başarısız Tekrar Deneyin");
                    }
                }
            }
            //_notyfService.Success("Başarıyla Kayıt Oldunuz.");
            return View(p);
        }

        [HttpGet]
        public IActionResult SingIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SingIn(UserSingInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Profile", new { area = "Member" });
                }
            }
            else
            {
                return RedirectToAction("SingIn", "Login");
            }
            return View();
        }
    }
}
