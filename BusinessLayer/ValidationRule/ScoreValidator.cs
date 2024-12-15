using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRule
{
    public class ScoreValidator:AbstractValidator<Score>
    {
        public ScoreValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id is required");
            RuleFor(x => x.Point).NotNull().WithMessage("Point can not be empty");
            RuleFor(x => x.UserId).NotNull().WithMessage("UserId can not be empty");
        }
    }
}
