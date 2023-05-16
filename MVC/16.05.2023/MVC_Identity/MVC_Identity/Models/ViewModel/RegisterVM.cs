using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVC_Identity.Models.ViewModel
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez!")]
        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email boş geçilemez!")]
        [Display(Name = "Eposta")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Şifre(Tekrar) boş geçilemez!")]
        [Display(Name = "Şifre (Tekrar)")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor!")]
        public string ConfirmPassword { get; set; }
    }
}
