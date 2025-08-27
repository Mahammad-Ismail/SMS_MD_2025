

using System.ComponentModel.DataAnnotations;

namespace SMS_MD.Models.Login
{
    public class UserDto
    {
        [Required(ErrorMessage ="Please Enter Email Or UserName is "), Display (Name = "Email Or UserName")]
        public string EmailOrUserName { get; set; }

        [Required(ErrorMessage ="Please Enter Password"), Display(Name = "Password")]
        public string Password { get; set; }

    }
}
