class Notification
{
    public virtual void Notify()
    {

    }
}
class EmailNotification : Notification
{
    public override void Notify()
    {
        Console.WriteLine("You have Email Notification!");
    }
}
class SmsNotification : Notification
{
    public override void Notify()
    {
        Console.WriteLine("You have SMS Notification!");
    }
}
class PushNotification : Notification
{
    public override void Notify()
    {
        Console.WriteLine("You have Push Notification!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        EmailNotification emailNotification = new EmailNotification();
        SmsNotification smsNotification = new SmsNotification();
        PushNotification pushNotification = new PushNotification();

        Notification[] notifications = { emailNotification, smsNotification, pushNotification };

        foreach (Notification n in notifications)
        {
            n.Notify();
        }
    }
}