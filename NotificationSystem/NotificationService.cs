public class NotificationService
{
    private readonly INotificationChannel _notification;

    public NotificationService(INotificationChannel notification)
    {
        _notification = notification;
    }

    public void SendNotification(string message)
    {
        _notification.Send(message);
    }
}
