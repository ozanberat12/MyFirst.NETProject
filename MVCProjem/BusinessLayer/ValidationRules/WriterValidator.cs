using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Boş geçilemez").
                MaximumLength(50).WithMessage("max 50").
                MinimumLength(2).WithMessage("min 2");

            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Boş Geçilemez").
                Must(x => x.ToUpper().Contains("?")).WithMessage("? olmalı");

            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Boş geçilemez");

            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Boş geçilemez").MaximumLength(25).
                WithMessage("max 25").MinimumLength(3).WithMessage("min 2");

        }
    }
}
