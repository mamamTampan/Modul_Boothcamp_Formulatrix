namespace StringAndTextHandling
{
	class Program
	{
		static void Main(string[] args)
		{
			// Example string
			string myString = "Hello, World!";

			// Accessing characters in a string
			Console.WriteLine(myString[0]); // H
			Console.WriteLine(myString[7]); // W

			// String concatenation
			string name = "John";
			string greeting = "Hello";
			string message = greeting + " " + name + "!";
			Console.WriteLine(message); // Hello John!

			// String interpolation
			string country = "USA";
			int year = 1776;
			string declaration = $"The {country} declared independence in {year}.";
			Console.WriteLine(declaration); // The USA declared independence in 1776.

			// String length
			Console.WriteLine(myString.Length); // 13

			// Substring
			string substring = myString.Substring(0, 5);
			Console.WriteLine(substring); // Hello

			// Converting string to uppercase
			string uppercaseString = myString.ToUpper();
			Console.WriteLine(uppercaseString); // HELLO, WORLD!

			// Converting string to lowercase
			string lowercaseString = myString.ToLower();
			Console.WriteLine(lowercaseString); // hello, world!

			// Removing whitespace
			string stringWithWhitespace = "   Hello, World!   ";
			string trimmedString = stringWithWhitespace.Trim();
			Console.WriteLine(trimmedString); // Hello, World!

			// Replacing characters
			string replacedString = myString.Replace("o", "0");
			Console.WriteLine(replacedString); // Hell0, W0rld!

			// Splitting strings
			string sentence = "The quick brown fox jumps over the lazy dog.";
			string[] words = sentence.Split(' ');
			foreach (string word in words)
			{
				Console.WriteLine(word + ",");
			}

			//Access character within string
			foreach (char c in "helloworld")
			{
				Console.Write(c + ",");
			}

			//Searching within String
			bool Endswith = ("quick brown fox".EndsWith("fox")); // True
			Console.WriteLine(Endswith);
			bool Startswith = ("quick brown fox".StartsWith("quick")); // True
			Console.WriteLine(Startswith);
			bool Contains = ("quick brown fox".Contains("brown")); // True
			Console.WriteLine(Contains);
			
			//IndexOfAny returns the first matching position of any one of a set of characters:
			Console.WriteLine("ab,cd ef".IndexOfAny(new char[] { ' ', ',' })); // 2
			Console.WriteLine("pas5w0rd".IndexOfAny("0123456789".ToCharArray())); // 3
		}
	}
}