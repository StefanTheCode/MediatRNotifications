using MediatR;

namespace MediatRNotifications.MediatR.Models;

public class AccidentNotification : INotification
{
    public AccidentNotification(string location)
    {
        Location = location;
    }

    public string Location { get;  }
}