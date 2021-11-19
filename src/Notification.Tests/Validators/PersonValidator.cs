using System;
using FluentValidation;
using Tolitech.CodeGenerator.Notification.Tests.Models;

namespace Tolitech.CodeGenerator.Notification.Tests.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(10);
        }
    }
}