
namespace Object
{
    static class Program
    {
        static void Main()
        {
            int x = 5;
            object obj1 = x; // boxing
            int y = (int)obj1; // unboxing
            Console.WriteLine(y);

            int a = 10;
            object obj2 = a;
            //string str = (string)obj2; //will throw an exception if not use ToString()
            string str = ((int)obj2).ToString();
            Console.WriteLine(str);

            int c = 11;
            object obj3 = c;
            //long d = (long)(int)obj3; //no need to cast to long, because will cast explicitly
            long d = (int)obj3;
            Console.WriteLine(d);

            float e = 12.2f;
            object obj6 = e;
            //int i = (int)obj6; //will throw an exception
            int i = (int)(float)obj6;
            Console.WriteLine(i);

            object obj4 = "Hello, World! 1";
            if (obj4 is string)
            {
                string str4 = (string)obj4;
                Console.WriteLine(str4);
            }

            object obj5 = "Hello, World! 2";
            if (obj5 is string str5)
            {
                Console.WriteLine(str5);
            }

            object obj7 = 23;
            int j = obj7 as int? ?? 0;
            Console.WriteLine(j);
        }
    }
}