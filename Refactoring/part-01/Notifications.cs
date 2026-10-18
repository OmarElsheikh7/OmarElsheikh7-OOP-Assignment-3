namespace RefactoringLab;

public interface INotificationChannel
{
    public void Send(string to, string message);
}

public class EmailChannel : INotificationChannel
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[email] {to}: {message}");
}

public class SmsChannel : INotificationChannel
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[sms] {to}: {message}");
}

public class WhatsAppChannel : INotificationChannel
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[WhatsApp] {to}: {message}");
}

public class UrgentChannel : INotificationChannel
{
    private readonly INotificationChannel _innerChannel;

    public UrgentChannel(INotificationChannel innerChannel)
    {
        _innerChannel = innerChannel;
    }

    public void Send(string to, string message)
    {
        _innerChannel.Send(to, $"[URGENT] {message}");
    }
}

public class ScheduledChannel : INotificationChannel
{
    private readonly INotificationChannel _innerChannel;
    public DateTime sendAt;

    public ScheduledChannel(INotificationChannel innerChannel,DateTime sendat)
    {
        _innerChannel = innerChannel;
        sendAt = sendat;
    }

    public void Send(string to, string message)
    {
        _innerChannel.Send(to, $"[scheduled {sendAt:g}] {message}");
    }
}
