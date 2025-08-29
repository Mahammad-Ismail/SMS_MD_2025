using SMS_MD.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_MD.Services.Interfces
{
    public interface IAppUserService
    {
        bool ValidateUser(UserDto userdto);
    }
}
