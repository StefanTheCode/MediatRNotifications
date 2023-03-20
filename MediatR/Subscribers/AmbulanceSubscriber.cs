using MediatR;
using MediatRNotifications.MediatR.Models;

namespace MediatRNotifications.MediatR.Subscribers;

public class AmbulanceSubscriber : INotificationHandler<AccidentNotification>
{
    public async Task Handle(AccidentNotification notification, CancellationToken cancellationToken)
    {
        Console.WriteLine();
        Console.WriteLine($"On-call emergency assistance service received a notification about the accident.");
        Console.WriteLine($"Paramedics were sent to the location:: {notification.Location}");
    }
}