using DotNetCore.Validation;
using FluentValidation;

namespace Architecture.Model
{
    public abstract class UserModelValidator : Validator<UserModel>
    {
        public void RuleForAuth()
        {
            RuleFor(user => user.Auth).SetValidator(new AuthModelValidator());
        }

        public void RuleForEmail()
        {
            RuleFor(user => user.Email).NotEmpty();
        }

        public void RuleForId()
        {
            RuleFor(user => user.Id).NotEmpty();
        }

        public void RuleForName()
        {
            RuleFor(user => user.Name).NotEmpty();
        }

        public void RuleForSurname()
        {
            RuleFor(user => user.Surname).NotEmpty();
        }
    }
}
