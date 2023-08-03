using System.Security.AccessControl;
using System.IO;
using System.Text;
class Program {
    static void Main() {
        string path = "newfile.txt";

        using (FileStream fs = new FileStream(path, FileMode.Create)) {

            byte[] data = Encoding.UTF8.GetBytes("Hello, FileStream!"); 
            fs.Write(data, 0, data.Length); //data, offset, count
        }

        // Open the file for reading
        using (FileStream fs = new FileStream(path, FileMode.Open)) {
            byte[] buffer = new byte[fs.Length]; 
            fs.Read(buffer, 0, buffer.Length); //buffer, offset, count
            string content = Encoding.UTF8.GetString(buffer); 
            Console.WriteLine(content);
        }
    }
}
