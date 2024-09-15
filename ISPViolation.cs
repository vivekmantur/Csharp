public interface INotification
{
    void SendEmail(string message);
    void SendSMS(string message);
    void SendPushNotification(string message);
}

// Implementing INotification in an Email-only notifier
public class EmailNotifier : INotification
{
    public void SendEmail(string message)
    {
        Console.WriteLine("Sending Email: " + message);
    }

    public void SendSMS(string message)
    {
        throw new NotImplementedException("Email notifier cannot send SMS.");
    }

    public void SendPushNotification(string message)
    {
        throw new NotImplementedException("Email notifier cannot send push notifications.");
    }
}

// Implementing INotification in an SMS-only notifier
public class SMSNotifier : INotification
{
    public void SendEmail(string message)
    {
        throw new NotImplementedException("SMS notifier cannot send emails.");
    }

    public void SendSMS(string message)
    {
        Console.WriteLine("Sending SMS: " + message);
    }

    public void SendPushNotification(string message)
    {
        throw new NotImplementedException("SMS notifier cannot send push notifications.");
    }
}
public class Program
{
    public static void Main()
    {
        INotification emailNotifier = new EmailNotifier();
        emailNotifier.SendEmail("Hello via Email!"); // Works fine
        emailNotifier.SendSMS("Hello via SMS!");     // Throws NotImplementedException

        INotification smsNotifier = new SMSNotifier();
        smsNotifier.SendSMS("Hello via SMS!");       // Works fine
        smsNotifier.SendEmail("Hello via Email!");   // Throws NotImplementedException
    }
}
