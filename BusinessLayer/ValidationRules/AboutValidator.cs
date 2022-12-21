using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmı boş geçilemez!");
            RuleFor(x => x.Title).MinimumLength(4).WithMessage("Başlık en az 4 karakter olmalıdır.").MaximumLength(100).WithMessage("Başlık en fazla 100 karakter olabilir");
        }
    }
}
