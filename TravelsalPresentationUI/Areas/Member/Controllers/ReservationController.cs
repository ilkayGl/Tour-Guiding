using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace TravelsalPresentationUI.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    [Authorize]
    public class ReservationController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly IReservationService _reservationService;
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(IDestinationService destinationService, IReservationService reservationService, UserManager<AppUser> userManager)
        {
            _destinationService = destinationService;
            _reservationService = reservationService;
            _userManager = userManager;
        }



        [HttpGet]
        public IActionResult MyActiveReservation()
        {

            return View();
        }

        [HttpGet]
        public IActionResult MyOldReservation()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> MyApprovalReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            var valuesList = _reservationService.GetListWithReservationByWaitApproval(values.Id);

            return View(valuesList);
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> deger1 = (from x in _destinationService.GetList()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.DestinationID.ToString()

                                           }).ToList();

            ViewBag.dgr1 = deger1;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewReservation(Reservation reservation)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            reservation.AppUserId = values.Id;
            reservation.CreationDate = DateTime.Parse(DateTime.Now.ToString());
            reservation.Status = "Onay Bekliyor";
            _reservationService.TAdd(reservation);
            return RedirectToAction("MyApprovalReservation");
        }
    }
}
