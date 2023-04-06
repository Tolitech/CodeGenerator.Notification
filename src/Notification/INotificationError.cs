using System;

namespace Tolitech.CodeGenerator.Notification
{
    public interface INotificationError : INotification
    {
        Exception? GetException();
    }
}
