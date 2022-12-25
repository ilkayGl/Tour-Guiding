using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace TravelsalPresentationUI.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Adresinizi Giriniz.")]
        public string Mail { get; set; }

        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Lütfen Parolanızı Giriniz.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Parolalar Uyuşmuyor")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
