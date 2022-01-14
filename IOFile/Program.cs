using System;
using System.IO;

namespace IOFile
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("abc.txt", "Hello");
            string a = File.ReadAllText("abc.txt");
            Console.WriteLine(a);
        }
    }
}
