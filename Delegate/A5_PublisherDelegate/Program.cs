// Delegate
public delegate void DelegatePub(string message);

public class Publisher
{
    // Delegate instance untuk mendaftarkan subscriber
    public DelegatePub SentNotif;

    public void SendMessage(string message)
    {
        SentNotif?.Invoke(message);
    }
}

public class Subscriber
{
    public void OnMessageReceived(string message)
    {
        Console.WriteLine($"Subscriber menerima pesan: {message}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber1 = new Subscriber();
        Subscriber subscriber2 = new Subscriber();

        publisher.SentNotif += subscriber1.OnMessageReceived;
        publisher.SentNotif += subscriber2.OnMessageReceived;

        publisher.SendMessage("Halo, ini pesan!");
    }
}