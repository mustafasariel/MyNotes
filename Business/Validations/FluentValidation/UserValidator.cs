using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validations.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.Password).NotEmpty();
            RuleFor(p => p.Password).Length(5).WithMessage("Parola min 5 karakter olmalıdır.");
            RuleFor(p => p.UserName).Must(fullaAlfanumeric).WithMessage("sayısal karakter olmaz");

        }

        private bool fullaAlfanumeric(string arg)
        {
            
            foreach (var item in arg)
            {
                if ( char.IsDigit(item))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
