using System;
using Tolitech.CodeGenerator.Notification.Tests.Validators;

namespace Tolitech.CodeGenerator.Notification.Tests.Models
{
    public class Person : Entity
    {
        public Person(string? name)
        {
            Name = name;
        }

        public string? Name { get; set; }

        public override void Validate()
        {
            base.Validate();
            var validator = new PersonValidator();
            Validate(validator.Validate(this));
        }
    }
}
