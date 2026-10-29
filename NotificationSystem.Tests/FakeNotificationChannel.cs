public class FakeNotificationChannel : INotificationChannel
{
    public string? LastMessage { get; set; }

    public void Send(string message)
    {
        LastMessage = message;
    }
}
