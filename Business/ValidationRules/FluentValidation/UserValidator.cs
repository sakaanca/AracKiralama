using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Entities.DTOs;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator :AbstractValidator<UserForRegisterDto>
    {
        public UserValidator()
        {
            RuleFor(u=>u.Email).NotEmpty();
            RuleFor(u=>u.Password).NotEmpty();
            RuleFor(u=>u.FirstName).NotEmpty();
            RuleFor(u=>u.LastName).NotEmpty();
            
        }
    }
}
