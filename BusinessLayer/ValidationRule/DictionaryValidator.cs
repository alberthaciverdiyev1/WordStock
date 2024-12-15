using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRule
{
    public class DictionaryValidator:AbstractValidator<Dictionary>
    {
        public DictionaryValidator()
        {
            RuleFor(x=>x.EngWord).NotNull().NotEmpty().WithMessage("Foreign word can not be empty");
            RuleFor(x=>x.AzeWord).NotNull().NotEmpty().WithMessage("Local word can not be empty");
        }
    }
}
