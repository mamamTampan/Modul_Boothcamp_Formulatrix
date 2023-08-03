
namespace FileHandlinDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			string FilePath = @".\MyFile.txt";

			using (FileStream fileStream = new FileStream(FilePath, FileMode.Create, FileAccess.Read, FileShare.Inheritable))
			{
				fileStream.Close();
				Console.Write("File has been created and the Path is MyFile.txt");
			}
			Console.ReadKey();
		}
	}
}