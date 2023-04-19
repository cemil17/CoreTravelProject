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
			RuleFor(x => x.Header).NotEmpty().WithMessage("Bu alan boş geçilemez");
			RuleFor(x => x.Description).NotEmpty().WithMessage("Bu alan boş geçilemez");
			RuleFor(x => x.Image).NotEmpty().WithMessage("Bu alan boş geçilemez");

			RuleFor(x => x.Header).MinimumLength(5).WithMessage("En az beş (5) karakter girin");
			RuleFor(x => x.Description).MinimumLength(5).WithMessage("En az beş (5) karakter girin");
			RuleFor(x => x.Image).MinimumLength(5).WithMessage("En az beş (5) karakter girin");

			RuleFor(x => x.Header).MaximumLength(100).WithMessage("En fazla yüz (100) karakter girebilirsin");


		}
	}
}
