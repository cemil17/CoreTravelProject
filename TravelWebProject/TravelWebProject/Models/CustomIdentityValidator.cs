using Microsoft.AspNetCore.Identity;

namespace TravelWebProject.Models
{
	public class CustomIdentityValidator:IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError
			{
				Code = "PasswordTooShort",
				Description = $"Parola minimum {length} karakter olmalıdır."
			};
		}
		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError
			{
				Code = "PasswordRequiresUpper",
				Description = $"Parola en az bir büyük harf içermelidir."
			};
		}
		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError
			{
				Code = "PasswordRequiresUpper",
				Description = $"Parola en az bir küçük harf içermelidir."
			};
		}
		public override IdentityError PasswordRequiresDigit()
		{
			return new IdentityError
			{
				Code = "PasswordRequiresDigit",
				Description = $"Parolada bir sayısal karakter bulunmalıdır."
			};
		}
		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError
			{
				Code = "PasswordRequiresNonAlphanumeric",
				Description = $" Girilen parolada alfasayısal olmayan (+*/- vb.) bir karakter bulunmalıdır."
			};
		}
		public override IdentityError DuplicateUserName(string userName)
		{
			return new IdentityError
			{
				Code = "DuplicateUserName",
				Description = $" Kullanıcı adı {userName} daha önce alınmış."
			};
		}
		public override IdentityError DuplicateEmail(string email)
		{
			return new IdentityError
			{
				Code = "DuplicateEmail",
				Description = $" Bu {email} adres sistemde kayıtlı."
			};
		}
	}
}
