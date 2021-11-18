using System;
using System.Linq;
using Xunit;
using Tolitech.CodeGenerator.Notification.Tests.Models;

namespace Tolitech.CodeGenerator.Notification.Tests
{
    public class NotificationTest
    {
        [Fact(DisplayName = "NotificationResult - MaximumLength - Invalid")]
        public void NotificationResult_MaximumLength_Invalid()
        {
            var model = new TestModel() { Name = "This name cannot contain more than 10 characters." };
            Assert.False(model.IsValid());
        }

        [Fact(DisplayName = "NotificationResult - AddMessageWithObject - Valid")]
        public void NotificationResult_AddMessageWithObject_Valid()
        {
            var result = new NotificationResult();
            result.AddMessage(new NotificationMessage("key", "message", "info"));
            Assert.True(result.IsValid);
        }

        [Fact(DisplayName = "NotificationResult - AddMessageWithTwoParameters - Valid")]
        public void NotificationResult_AddMessageWithTwoParameters_Valid()
        {
            var result = new NotificationResult();
            result.AddMessage("message", "info");
            Assert.True(result.IsValid);
        }

        [Fact(DisplayName = "NotificationResult - AddMessageWithTwoParameters - Invalid")]
        public void NotificationResult_AddMessageWithTwoParameters_Invalid()
        {
            var result = new NotificationResult();
            result.AddMessage("message", "error");
            Assert.False(result.IsValid);
        }

        [Fact(DisplayName = "NotificationResult - AddMessageWithOneParameter - Valid")]
        public void NotificationResult_AddMessageWithOneParameter_Valid()
        {
            var result = new NotificationResult();
            result.AddMessage("message");
            Assert.True(result.IsValid);
        }

        [Fact(DisplayName = "NotificationResult - AddMessageOnTop - Valid")]
        public void NotificationResult_AddMessageOnTop_Valid()
        {
            var result = new NotificationResult();
            result.AddMessageOnTop("message");
            Assert.True(result.IsValid);
        }

        [Fact(DisplayName = "NotificationResult - AddErrorWithException - Invalid")]
        public void NotificationResult_AddErrorWithException_Invalid()
        {
            var result = new NotificationResult();
            result.AddError(new Exception("exception"));
            Assert.False(result.IsValid);
        }

        [Fact(DisplayName = "NotificationResult - AddErrorWithObject - Invalid")]
        public void NotificationResult_AddErrorWithObject_Invalid()
        {
            var result = new NotificationResult();
            result.AddError(new NotificationError("key", new Exception("Exception")));
            Assert.False(result.IsValid);
        }

        [Fact(DisplayName = "NotificationResult - AddErrorWithOneParameterAndException - Invalid")]
        public void NotificationResult_AddErrorWithOneParameterAndException_Invalid()
        {
            var result = new NotificationResult();
            result.AddError("key", new Exception("Exception"));
            Assert.False(result.IsValid);
        }

        [Fact(DisplayName = "NotificationResult - AddErrorWithTwoParameters - Invalid")]
        public void NotificationResult_AddErrorWithTwoParameters_Invalid()
        {
            var result = new NotificationResult();
            result.AddError("key", "message");
            Assert.False(result.IsValid);
        }

        [Fact(DisplayName = "NotificationResult - AddErrorWithOneParameter - Invalid")]
        public void NotificationResult_AddErrorWithOneParameter_Invalid()
        {
            var result = new NotificationResult();
            result.AddError("message");
            Assert.False(result.IsValid);
        }

        [Fact(DisplayName = "NotificationResult - AddErrorOnTop - Invalid")]
        public void NotificationResult_AddErrorOnTop_Invalid()
        {
            var result = new NotificationResult();
            result.AddErrorOnTop("message");
            Assert.False(result.IsValid);
        }

        [Fact(DisplayName = "NotificationResult - InsertMessageWithObject - Valid")]
        public void NotificationResult_InsertMessageWithObject_Valid()
        {
            var result = new NotificationResult();
            result.InsertMessage(0, new NotificationMessage("key", "message", "info"));
            Assert.True(result.IsValid);
        }

        [Fact(DisplayName = "NotificationResult - InsertMessageWithTwoParameters - Valid")]
        public void NotificationResult_InsertMessageWithTwoParameters_Valid()
        {
            var result = new NotificationResult();
            result.InsertMessage(0, "message", "info");
            Assert.True(result.IsValid);
        }

        [Fact(DisplayName = "NotificationResult - InsertMessageWithOneParameter - Valid")]
        public void NotificationResult_InsertMessageWithOneParameter_Valid()
        {
            var result = new NotificationResult();
            result.InsertMessage(0, "message");
            Assert.True(result.IsValid);
        }

        [Fact(DisplayName = "NotificationResult - InsertMessageWithObject - Invalid")]
        public void NotificationResult_InsertMessage_Invalid()
        {
            var result = new NotificationResult();
            result.InsertMessage(0, new NotificationMessage("key", "message", "error"));
            Assert.False(result.IsValid);
        }

        [Fact(DisplayName = "NotificationResult - InsertMessageWithTwoParameters - Invalid")]
        public void NotificationResult_InsertMessageWithTwoParameters_Invalid()
        {
            var result = new NotificationResult();
            result.InsertMessage(0, "message", "error");
            Assert.False(result.IsValid);
        }

        [Fact(DisplayName = "NotificationResult - InsertErrorWithOneParameter - Invalid")]
        public void NotificationResult_InsertErrorWithOneParameter_Invalid()
        {
            var result = new NotificationResult();
            result.InsertError(0, "message");
            Assert.False(result.IsValid);
        }

        [Fact(DisplayName = "NotificationResult - InsertErrorWithTwoParameters - Invalid")]
        public void NotificationResult_InsertErrorWithTwoParameters_Invalid()
        {
            var result = new NotificationResult();
            result.InsertError(0, "key", "message");
            Assert.False(result.IsValid);
        }

        [Fact(DisplayName = "NotificationResult - InsertErrorWithException - Invalid")]
        public void NotificationResult_InsertErrorWithException_Invalid()
        {
            var result = new NotificationResult();
            result.InsertError(0, new Exception("exception"));
            Assert.False(result.IsValid);
        }

        [Fact(DisplayName = "NotificationResult - InsertErrorWithOneParameterAndException - Invalid")]
        public void NotificationResult_InsertErrorWithOneParameterAndException_Invalid()
        {
            var result = new NotificationResult();
            result.InsertError(0, "key", new Exception("exception"));
            Assert.False(result.IsValid);
        }

        [Fact(DisplayName = "NotificationResult - InsertErrorWithObject - Invalid")]
        public void NotificationResult_InsertErrorWithObject_Invalid()
        {
            var result = new NotificationResult();
            result.InsertError(0, new NotificationError("key", "message"));
            Assert.False(result.IsValid);
        }

        [Fact(DisplayName = "NotificationResult - Add - Valid")]
        public void NotificationResult_Add_Valid()
        {
            var resultOne = new NotificationResult();
            
            var resultTwo = new NotificationResult();
            resultTwo.AddMessage("message");

            resultOne.Add(resultTwo);
            Assert.True(resultOne.IsValid);
        }

        [Fact(DisplayName = "NotificationResult - Add - Invalid")]
        public void NotificationResult_Add_Invalid()
        {
            var resultOne = new NotificationResult();

            var resultTwo = new NotificationResult();
            resultTwo.AddError("message");

            resultOne.Add(resultTwo);
            Assert.False(resultOne.IsValid);
        }

        [Fact(DisplayName = "NotificationResult - ClearMessages - Valid")]
        public void NotificationResult_ClearMessages_Valid()
        {
            var result = new NotificationResult();
            result.AddMessage("message");
            result.ClearMessages();
            Assert.True(result.Messages.Count() == 0);
        }

        [Fact(DisplayName = "NotificationResult - ClearErrors - Valid")]
        public void NotificationResult_ClearErrors_Valid()
        {
            var result = new NotificationResult();
            result.AddError("message");
            result.ClearErrors();
            Assert.True(result.Errors.Count() == 0);
        }

        [Fact(DisplayName = "NotificationResult - RemoveMessage - Valid")]
        public void NotificationResult_RemoveMessage_Valid()
        {
            var result = new NotificationResult();
            var message = new NotificationMessage("message");
            result.AddMessage(message);
            result.RemoveMessage(message);
            Assert.True(result.Messages.Count() == 0);
        }

        [Fact(DisplayName = "NotificationResult - RemoveMessageByKey - Valid")]
        public void NotificationResult_RemoveMessageByKey_Valid()
        {
            var result = new NotificationResult();
            var message = new NotificationMessage("key", "message", "info");
            result.AddMessage(message);
            result.RemoveMessage("key");
            Assert.True(result.Messages.Count() == 0);
        }

        [Fact(DisplayName = "NotificationResult - RemoveError - Valid")]
        public void NotificationResult_RemoveError_Valid()
        {
            var result = new NotificationResult();
            var error = new NotificationError("message");
            result.AddError(error);
            result.RemoveError(error);
            Assert.True(result.Errors.Count() == 0);
        }

        [Fact(DisplayName = "NotificationResult - RemoveErrorByKey - Valid")]
        public void NotificationResult_RemoveErrorByKey_Valid()
        {
            var result = new NotificationResult();
            var error = new NotificationError("key", "message");
            result.AddError(error);
            result.RemoveError("key");
            Assert.True(result.Errors.Count() == 0);
        }

        [Fact(DisplayName = "NotificationResult - DynamicData - Valid")]
        public void NotificationResult_DynamicData_Valid()
        {
            var result = new NotificationResult();
            result.Data = new { ok = true };
            Assert.True(result.Data != null);
        }
    }
}