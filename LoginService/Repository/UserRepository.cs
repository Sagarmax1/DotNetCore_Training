using LoginService.EntityFramework;
using LoginService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginService.Repository
{
    public class UserRepository : IUserService
    {

        ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)   //DI
        {
            this._context = context;
        }
        public int CreateUser(User user)
        {
            this._context.Add(user);
            this._context.SaveChanges();
            return 1;
        }

        public bool LoginValidate(string username, string password)
        {
            var temp = this._context.users.Where(s => s.UserName == username && s.Password == password).FirstOrDefault();
            // var temp = "";
            if (temp == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
