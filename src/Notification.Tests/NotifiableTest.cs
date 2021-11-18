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
            var model = new TestModel();
            var result = model.GetNotifications();
            Assert.True(model.IsValid() == result.IsValid);
        }

        [Fact(DisplayName = "Notifiable - ValidModel - Valid")]
        public void Notifiable_ValidModel_Valid()
        {
            var model = new TestModel() { Name = "Valid name" };
            Assert.True(model.IsValid());
        }

        [Fact(DisplayName = "Notifiable - Empty - Invalid")]
        public void Notifiable_Empty_Invalid()
        {
            var model = new TestModel() { Name = "" };
            Assert.False(model.IsValid());
        }

        [Fact(DisplayName = "Notifiable - Null - Invalid")]
        public void Notifiable_Null_Invalid()
        {
            var model = new TestModel() { Name = null };
            Assert.False(model.IsValid());
        }
    }
}
