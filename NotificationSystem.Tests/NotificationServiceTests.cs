namespace NotificationSystem.Tests;

public class NotificationServiceTests
{
    [Fact]
    public void SendNotification_SendsMessageToChannel()
    {
        // Arrange
        var fakeChannel = new FakeNotificationChannel();
        var fakeService = new NotificationService(fakeChannel);

        // Act
        string fakeMessage = "Fake Message";
        fakeService.SendNotification(fakeMessage);

        // Assert
        Assert.Equal(fakeMessage, fakeChannel.LastMessage);
    }
}
