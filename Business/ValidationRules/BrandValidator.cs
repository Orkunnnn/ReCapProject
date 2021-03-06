﻿using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.BrandName).NotEmpty().MinimumLength(2);
        }
    }
}
