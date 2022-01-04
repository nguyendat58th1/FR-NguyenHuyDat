using System;

namespace EnumAndConst
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle ci = new Circle();
            ci.Input();
            Console.WriteLine($"Area = {ci.GetArea()}");
            Console.WriteLine($"Perimeter = {ci.GetPerimater()}");
        }
    }
    class Circle
    {
        public double radius;
        private const double pi = 3.14;
        public void Input()
        {
            Console.Write("Radius = ");
            this.radius = Double.Parse(Console.ReadLine());
        }
        public double GetArea()
        {
            return pi * Math.Pow(this.radius, 2);
        }
        public double GetPerimater()
        {
            return pi * this.radius * 2;
        }
    }
}
