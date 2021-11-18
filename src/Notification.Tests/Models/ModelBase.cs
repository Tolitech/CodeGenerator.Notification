using System;
using FluentValidation.Results;

namespace Tolitech.CodeGenerator.Notification.Tests.Models
{
    public abstract class ModelBase : Notifiable
    {
        public void Validate(ValidationResult result)
        {
            NotificationResult.Clear();

            foreach (var error in result.Errors)
            {
                NotificationResult.AddError(error.ErrorMessage);
            }
        }
    }
}
