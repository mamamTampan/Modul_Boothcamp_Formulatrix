using System;
using System.IO;
namespace FileHandlinDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string filePath = "MyFile.txt";

           
            StreamReader streamReader = new StreamReader(filePath);

            Console.WriteLine("Content of the File");

            // This is used to specify from where to start reading the input stream
            // BaseStream: Returns the underlying stream.
            // Seek: The new position within the current stream.
            // SeekOrigin.Begi: Specifies the beginning of a stream
            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

            
            string strData = streamReader.ReadLine();

           
            while (strData != null)
            {
                Console.WriteLine(strData);
                strData = streamReader.ReadLine();
            }
            Console.ReadLine();

            streamReader.Close();
            Console.ReadKey();
        }
    }
}