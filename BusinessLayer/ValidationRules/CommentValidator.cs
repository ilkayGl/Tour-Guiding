using EntitiyLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer.ValidationRules
{
    public class CommentValidator : AbstractValidator<Comment>
    {
        public CommentValidator()
        {
            RuleFor(x => x.CommentUser).NotEmpty().WithMessage("İsim kısmını boş geçemessiniz");
            RuleFor(x => x.CommentSate).NotEmpty().WithMessage("Mesaj kısmını boş geçemessiniz");
        }
    }
}
