var smsService = new NotificationService(new SmsNotification());
smsService.SendNotification("Message from my phone!");

var whatsappService = new NotificationService(new WhatsAppNotification());
whatsappService.SendNotification("Message from my computer!");
