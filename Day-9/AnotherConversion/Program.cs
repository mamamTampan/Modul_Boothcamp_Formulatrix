using System;
using System.Xml;
class Program
{
	static void Main()
	{
		// Parsing hexadecimal string to integer
		int hexToInt = Convert.ToInt32("1E", 16); // Parse in hexadecimal (30)
		Console.WriteLine(hexToInt); // Output: 30

		// Parsing binary string to integer
		int five = Convert.ToInt32("101", 2); // Parse in binary (5)
		Console.WriteLine(five); // Output: 5

		// Using dynamic data type for implicit conversion
		dynamic myInt = 123;
		dynamic myString = "456";
		
		// Convert int to a string
		myString = myInt.ToString();
		Console.WriteLine(myString); // Output: "123"

		// Convert string to an integer
		bool convertStringtoInt = int.TryParse(myString, out int intParse);
		Console.WriteLine(intParse + " " + convertStringtoInt); // Output: 456 true

		// Convert int to a double
		double  myDouble = intParse;
		Console.WriteLine(myDouble); // Output: 123.0

		// Converting data types using Convert.ChangeType method
		Type targetType = typeof(int);
		object source = "42";
		object result = Convert.ChangeType(source, targetType);
		Console.WriteLine(result); // Output: 42
		Console.WriteLine(result.GetType()); // Output: System.Int32
		

		// Converting boolean to string and back using XmlConvert
		string s = XmlConvert.ToString(true); // s = "true"
		bool isTrue = XmlConvert.ToBoolean("true");
		Console.WriteLine(isTrue); // Output: True

		// Converting double to byte array using BitConverter
		byte[] bytes = new byte[8];
		bytes = BitConverter.GetBytes(123.456);
		foreach (var b in bytes)
		{
			Console.Write(b + " "); // Output: 0 0 0 0 0 0 94 64
		}
		Console.WriteLine("");
		
		// Converting byte array back to double
		double dblValue = BitConverter.ToDouble(bytes, 0);
		Console.WriteLine(dblValue); // Output: 123.456
	}
}
