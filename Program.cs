var smsService = new NotificationService(new SmsNotification());
smsService.SendNotification("Message from my phone!");

var whatsappService = new NotificationService(new WhatsAppNotification());
whatsappService.SendNotification("Message from my computer!");

// Arrange
var fakeChannel = new FakeNotificationChannel();
var fakeService = new NotificationService(fakeChannel);

// Act
string fakeMessage = "Fake Message";
fakeService.SendNotification(fakeMessage);

// Assert
if (fakeChannel.LastMessage == fakeMessage)
{
    Console.WriteLine("Test Passed");
}
else
{
    Console.WriteLine("Test Failed");
}
