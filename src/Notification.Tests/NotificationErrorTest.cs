using System;
using Xunit;

namespace Tolitech.CodeGenerator.Notification.Tests
{
    public class NotificationErrorTest
    {
        [Fact(DisplayName = "NotificationError - AddException - Valid")]
        public void NotificationError_AddException_Valid()
        {
            var result = new NotificationError(new Exception("message"));
            var exception = result.GetException();
            Assert.True(exception is Exception);
        }
    }
}
