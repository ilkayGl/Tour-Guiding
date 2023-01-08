using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using TravelsalPresentationUI.Areas.Member.Models;

namespace TravelsalPresentationUI.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new();
            userEditViewModel.name = values.Name;
            userEditViewModel.surname = values.Surname;
            userEditViewModel.phonenumber = values.PhoneNumber;
            userEditViewModel.mail = values.Email;

            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (p.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/userImages/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                user.ImageUrl = imageName;
            }
            user.Name = p.name;
            user.Surname = p.surname;
            user.PhoneNumber = p.phonenumber;
            user.Email = p.mail;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.password);

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("SingIn", "Login");
            }

            return View();
        }
    }
}
