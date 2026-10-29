public class SmsNotification : INotificationChannel
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}
