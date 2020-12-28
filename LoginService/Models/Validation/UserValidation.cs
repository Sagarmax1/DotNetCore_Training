using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace LoginService.Models.Validation
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(t => t.UserName).NotEmpty();

            RuleFor(t => t.Password).NotEmpty();
        }

    }
}
