public class Publisher
{
	public string name = "Publisher";
	public event EventHandler<string> MessageSent;

	public void SendMessage(string message)
	{
		MessageSent?.Invoke(this, message);
	}
}

public class Subscriber
{
	public void OnMessageReceived(object sender, string message)
	{
		Console.WriteLine($"Subscriber menerima pesan: {message} dari {((Publisher)sender).name}");
	}
}

public class Program
{
	public static void Main(string[] args)
	{
		Publisher publisher = new Publisher();
		Subscriber subscriber1 = new Subscriber();
		Subscriber subscriber2 = new Subscriber();

		// Mendaftarkan metode subscriber ke event
		publisher.MessageSent += subscriber1.OnMessageReceived;
		publisher.MessageSent += subscriber2.OnMessageReceived;

		publisher.SendMessage("Halo, ini pesan untuk semua subscriber!");
	}
}