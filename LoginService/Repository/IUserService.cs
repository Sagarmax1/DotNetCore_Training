using LoginService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginService.Repository
{
    public interface IUserService
    {
        int CreateUser(User user);
        bool LoginValidate(string username, string password);
    }
}
