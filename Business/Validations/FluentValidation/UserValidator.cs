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
            RuleFor(p => p.Password).Length(5).WithMessage("Parola 5 karakter olmalıdır.");
            RuleFor(p => p.FullName).MinimumLength(5).WithMessage("full name minumum 5 karakter olmalıdır.");



            RuleFor(p => p.UserName).Must(fullAlfanumeric).WithMessage("sayısal karakter olmaz");
            RuleFor(p => p.FullName).Must(isSpace).WithMessage("Fullname boşluk karakteri içermelidir.");


        }

        private bool isSpace(string arg)
        {
            return arg.Contains(" ");
        }

        private bool fullAlfanumeric(string arg)
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
