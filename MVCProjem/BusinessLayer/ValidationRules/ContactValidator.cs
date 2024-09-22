using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.Massage).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Boş Geçilemez");
        }
    }
}
