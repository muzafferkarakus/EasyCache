using DtoLayer.Dtos.AppUserDto;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad boş geçilemez!");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyadı boş geçilemez!");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı Adı boş geçilemez!");
            RuleFor(x => x.Email).NotEmpty().WithMessage("E-Posta boş geçilemez!");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("30 Karakterden fazla girilemez!");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("En az 2 karakter giriniz.");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Parolalar eşleşmiyor!");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz!");

        }
    }
}

