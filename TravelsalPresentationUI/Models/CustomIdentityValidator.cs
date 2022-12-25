using Microsoft.AspNetCore.Identity;

namespace TravelsalPresentationUI.Models
{
    public class CustomIdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError() { Code = "", Description = $"Parola Minimum {length} karakter olmalıdır." };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError() { Code = "", Description = $"Parola en az bir Alphanumeric (/$&*-+) karakter içermelidir." };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError() { Code = "", Description = $"Parola en az bir büyük harf içermelidir." };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError() { Code = "", Description = $"Parola en az bir Küçük harf içermelidir." };
        }

        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError() { Code = "", Description = $"Parola en az bir rakam (0-9) içermelidir." };
        }

    }
}
