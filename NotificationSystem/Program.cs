var smsService = new NotificationService(new SmsNotification());
smsService.SendNotification("Message from my phone!");

var whatsappService = new NotificationService(new WhatsAppNotification());
whatsappService.SendNotification("Message from my WhatsApp!");

var emailService = new NotificationService(new EmailNotification());
emailService.SendNotification("Message from my email!");
