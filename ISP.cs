// Step 1: Define specific interfaces for each notification type
public interface IEmailNotifier
{
    void SendEmail(string message);
}

public interface ISMSNotifier
{
    void SendSMS(string message);
}

public interface IPushNotifier
{
    void SendPushNotification(string message);
}

// Step 2: Implement classes that only implement the required interfaces

// EmailNotifier only implements IEmailNotifier
public class EmailNotifier : IEmailNotifier
{
    public void SendEmail(string message)
    {
        Console.WriteLine("Sending Email: " + message);
    }
}

// SMSNotifier only implements ISMSNotifier
public class SMSNotifier : ISMSNotifier
{
    public void SendSMS(string message)
    {
        Console.WriteLine("Sending SMS: " + message);
    }
}

// PushNotifier only implements IPushNotifier
public class PushNotifier : IPushNotifier
{
    public void SendPushNotification(string message)
    {
        Console.WriteLine("Sending Push Notification: " + message);
    }
}
public class Program
{
    public static void Main()
    {
        // Using email notifier
        IEmailNotifier emailNotifier = new EmailNotifier();
        emailNotifier.SendEmail("Hello via Email!");  // Works fine

        // Using SMS notifier
        ISMSNotifier smsNotifier = new SMSNotifier();
        smsNotifier.SendSMS("Hello via SMS!");        // Works fine

        // Using Push notifier
        IPushNotifier pushNotifier = new PushNotifier();
        pushNotifier.SendPushNotification("Hello via Push!");  // Works fine
    }
}
