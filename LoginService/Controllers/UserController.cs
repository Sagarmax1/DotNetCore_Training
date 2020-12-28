using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginService.Models;
using LoginService.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginService.Controllers
{
    // [Route("api/[controller]")]
    // [ApiController]

    [Route("path/[controller]")]
    public class UserController : ControllerBase
    {
        IUserService iuserservice;
        public UserController(IUserService iuserservice)
        {
            this.iuserservice = iuserservice;
        }

        [HttpPost("CreateAccount")]
        public ActionResult CreateUser([FromBody]User temp)
        {
            return Ok(iuserservice.CreateUser(temp));
        }

        [HttpPost("Login")]
        public ActionResult LoginValidate([FromBody]User temp)
        {
            return Ok(iuserservice.LoginValidate(temp.UserName, temp.Password));
        }


    }
}
