using Business.Conrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class MayoralCandidateValidator : AbstractValidator<MayoralCandidate>
    {
        public MayoralCandidateValidator()
        {
            RuleFor(mc => mc.UserId).NotEmpty().WithMessage("TC boş bırakılamaz.");
            RuleFor(mc => mc.UserId).Length(11).WithMessage("TC 11 karakter uzunluğunda olmalı");
        }
    }
}
