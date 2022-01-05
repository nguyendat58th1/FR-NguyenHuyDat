using System;
using System.Text;

namespace IfElseConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            float a, b, c;
            Console.Write("Nhập a : ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhập b : ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Nhập c : ");
            c = float.Parse(Console.ReadLine());
            FindX(a, b, c);
        }
        public static float Delta(float a, float b, float c)
        {
            return b * b - 4 * a * c;
        }
        public static void FindX(float a, float b, float c)
        {
            if (a == 0)
                Console.WriteLine($"Phương trình có nghiệm duy nhất : x = {-c/b}");
            else
            {
                float delta = Delta(a, b, c);
                if(delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                    double x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine($"Phương trình có 2 nghiệm : x1 = {x1} và x2 = {x2}");
                }
                else if (delta == 0)
                    Console.WriteLine($"Phương trình có nghiệm kép : x = {-b/2*a}");
                else Console.WriteLine("Phương trình vô nghiệm");

            }    
        }

    }
}
