using System;

namespace Tolitech.CodeGenerator.Notification
{
    public interface INotification
    {
        string? Key { get; }

        string? Message { get; }

        string? Type { get; }
    }
}
