using System.ComponentModel.DataAnnotations;

namespace RealHouzing.Consume.Models
{
    public class RegisterViewModel
    {
       public string Name { get; set; }
       public string Surname { get; set; }
       public string ImageURL { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Şifreler birbiriyle uyumlu değil!")]
        public string ConfirmPassword { get; set; }
    }
}
