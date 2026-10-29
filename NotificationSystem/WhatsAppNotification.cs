public class WhatsAppNotification : INotificationChannel
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending WhatsApp: {message}");
    }
}
