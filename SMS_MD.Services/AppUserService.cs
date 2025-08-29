using SMS_MD.Models.Login;
using SMS_MD.Services.Interfces;
namespace SMS_MD.Services
    
{
    public class AppUserService: IAppUserService
    {
        public bool ValidateUser(UserDto userdto)
        {
            return true;
        }
    }
}
