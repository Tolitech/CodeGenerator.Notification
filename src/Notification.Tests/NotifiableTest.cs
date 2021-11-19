using System;
using Xunit;
using Tolitech.CodeGenerator.Notification.Tests.Models;

namespace Tolitech.CodeGenerator.Notification.Tests
{
    public class NotifiableTest
    {
        [Fact(DisplayName = "Notifiable - GetNotifications - Valid")]
        public void Notifiable_GetNotifications_Valid()
        {
            var person = new Person(name: "Name");
            var result = person.GetNotifications();
            Assert.True(person.IsValid() == result.IsValid);
        }

        [Fact(DisplayName = "Notifiable - ValidModel - Valid")]
        public void Notifiable_ValidModel_Valid()
        {
            var person = new Person("Valid name");
            Assert.True(person.IsValid());
        }

        [Fact(DisplayName = "Notifiable - Empty - Invalid")]
        public void Notifiable_Empty_Invalid()
        {
            var person = new Person("");
            Assert.False(person.IsValid());
        }

        [Fact(DisplayName = "Notifiable - Null - Invalid")]
        public void Notifiable_Null_Invalid()
        {
            var person = new Person(null);
            Assert.False(person.IsValid());
        }
    }
}
