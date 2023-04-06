using System;

namespace Tolitech.CodeGenerator.Notification
{
    public class NotificationMessage : INotificationMessage
    {
        public string? Key { get; init; }

        public string? Message { get; init; }

        public string? Type { get; init; }

        public NotificationMessage(string? message)
        {
            Message = message;
            Type = "info";
        }

        public NotificationMessage(string? message, string? type)
        {
            Message = message;
            Type = type;
        }

        public NotificationMessage(string? key, string? message, string? type)
        {
            Key = key;
            Message = message;
            Type = type;
        }
    }
}
