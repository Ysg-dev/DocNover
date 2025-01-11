using System.ComponentModel.DataAnnotations;

namespace DocNover.Domain.Models.ViewModels
{
    public class LoginViewModels
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста, введите Ваше имя")]
        public string? UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Пожалуйста, введите пароль")]
        public string? Password { get; set; }
    }
}
