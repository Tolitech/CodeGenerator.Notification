using System;
using FluentValidation;
using Tolitech.CodeGenerator.Notification.Tests.Models;

namespace Tolitech.CodeGenerator.Notification.Tests.Validators
{
    public class TestValidator : AbstractValidator<TestModel>
    {
        public TestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(10);
        }
    }
}