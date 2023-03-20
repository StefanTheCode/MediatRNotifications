using MediatR;
using MediatRNotifications.MediatR.Models;

namespace MediatRNotifications.MediatR.Subscribers;

public class PoliceSubscriber : INotificationHandler<AccidentNotification>
{
    public async Task Handle(AccidentNotification notification, CancellationToken cancellationToken)
    {
        Console.WriteLine();
        Console.WriteLine($"The police service received a notification about the accident.");
        Console.WriteLine($"Police were dispatched to the location: {notification.Location}");
    }
}