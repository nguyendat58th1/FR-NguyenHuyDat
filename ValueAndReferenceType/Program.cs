using System;

namespace ValueAndReferenceType
{
    class Program
    {
        class ValueTypeNReferenceType
        {
            public static void Main(string[] args)
            {
                string name = "Peter";
                int number = 10;
                Console.WriteLine(name);
                Console.WriteLine(number);
                ChangelessName(name);
                ChangelessNumber(number);
                Console.WriteLine(name);
                Console.WriteLine(number);
                ChangeName(out name);
                ChangeNumber(ref number);
                Console.WriteLine(name);
                Console.WriteLine(number);

            }

            static string ChangelessName(string name)
            {
                name = "Eva";
                return name;
            }
            static int ChangelessNumber(int number)
            {
                return number++;
            }
            static string ChangeName(out string name)
            {
                name = "Steve";
                return name;
            }
            static int ChangeNumber(ref int number)
            {
                return number++;
            }
        }
    }
}
