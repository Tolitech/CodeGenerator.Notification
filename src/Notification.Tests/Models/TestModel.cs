using System;
using Tolitech.CodeGenerator.Notification.Tests.Validators;

namespace Tolitech.CodeGenerator.Notification.Tests.Models
{
    public class TestModel : ModelBase
    {
        public string? Name { get; set; }

        public override void Validate()
        {
            base.Validate();
            var validator = new TestValidator();
            Validate(validator.Validate(this));
        }
    }
}
