using RefactoringLab;
using RefactoringLab.Part_1;


var shipping = new ShippingCostCalculator();
Console.WriteLine($"Aramex 2kg → {shipping.Calculate(new Aramax(), 2)}");
Console.WriteLine($"FedEx 2kg  → {shipping.Calculate(new FedEx(), 2)}");

Console.WriteLine($"Bosta 2kg  → {shipping.Calculate(new Bosta(), 2)}");
Console.WriteLine();


var processor = new OrderProcessor(new SqlOrderRepository(), new SmtpEmailSender());
processor.Process(1001, "customer@example.com");
Console.WriteLine();


var urgentScheduledEmail = new ScheduledChannel(
    new UrgentChannel(new EmailChannel()),
    DateTime.Today.AddHours(18)
);
urgentScheduledEmail.Send("customer@example.com", "Your order ships tomorrow");


var urgentSms = new UrgentChannel(new SmsChannel());
urgentSms.Send("+201000000000", "OTP 4821");


var scheduledWhatsApp = new ScheduledChannel(
    new WhatsAppChannel(),
    DateTime.Today.AddDays(1)
);
scheduledWhatsApp.Send("+201000000000", "Welcome to WhatsApp notifications");