using MediatR;
using MediatRNotifications.MediatR.Models;

namespace MediatRNotifications.MediatR.Subscribers;

public class FireDepartmentSubscriber : INotificationHandler<AccidentNotification>
{
    public async Task Handle(AccidentNotification notification, CancellationToken cancellationToken)
    {
        Console.WriteLine();
        Console.WriteLine($"The fire department service received a notification about the accident.");
        Console.WriteLine($"Firefighters were dispatched to the location: {notification.Location}");
    }
}
