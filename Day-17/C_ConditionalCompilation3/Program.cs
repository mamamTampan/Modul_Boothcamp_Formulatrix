//Jika dirun pasti akan ke Debug
//dotnet build -c Release

#define PRODUCTION
class Program {
	static void Main() {
		#if (DEBUG)
		Console.WriteLine("Mode DEBUG diaktifkan.");
		#elif (PRODUCTION)
		Console.WriteLine("PRODUCTION mode aktif");
		#elif (DEVELOP)
		Console.WriteLine("DEVELOP mode aktif");
		#elif (FEATURE)
		Console.WriteLine("FEATURE mode aktif");
		#else
		Console.WriteLine("No define found");
		#endif
		
		Console.WriteLine("Program berjalan...");
		Console.Read();
	}
}
