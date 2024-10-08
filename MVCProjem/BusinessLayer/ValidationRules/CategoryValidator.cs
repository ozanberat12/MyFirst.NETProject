﻿using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori boş geçilemez");
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Açıklama boş geçilemez");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Minimum 3 karekter");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Maksimum 20 karekter");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori boş geçilemez");
        }

    }
}
