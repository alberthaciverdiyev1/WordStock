using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRule
{
    public class StatisticValidator:AbstractValidator<Statistic>
    {
        public StatisticValidator()
        {
            RuleFor(x=>x.Id).NotEmpty();
            RuleFor(x=>x.UserName).NotEmpty().NotNull().MinimumLength(3).MaximumLength(20).WithMessage("Username can not be null");
            RuleFor(x=>x.Type).NotEmpty().NotNull().WithMessage("Type can not be null");
        }
    }
}
