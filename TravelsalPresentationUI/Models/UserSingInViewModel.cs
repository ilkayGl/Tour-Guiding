using System.ComponentModel.DataAnnotations;

namespace TravelsalPresentationUI.Models
{
    public class UserSingInViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        public string Password { get; set; }
    }
}
