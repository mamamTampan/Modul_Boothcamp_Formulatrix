using System.Threading.Tasks;

class Program
{
	static void Main()
	{
		Task task = Task.Run(() => Console.WriteLine("Hello from Task 1!"));
		Task continuation = task.ContinueWith(t => Console.WriteLine("Hello from Task 2!"));
		continuation.Wait();
	}
}
