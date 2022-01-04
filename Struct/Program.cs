using System;

namespace Struct
{
    public struct Rectangle
    {
        public double Width;
        public double Height;

        public static void Input(out Rectangle re)
        {
            Console.Write("Height :");
            re.Height = Double.Parse(Console.ReadLine());
            Console.Write("Width : ");
            re.Width = Double.Parse(Console.ReadLine());
        
        }
        public static double Area(Rectangle re)
        {
            return re.Height * re.Width;
        }

        public static double Perimeter(Rectangle re)
        {
            return re.Height + re.Width;
        }

        public static Calculator GetAreaPerimeter(Rectangle re)
        {
            Calculator ca = new Calculator();
            ca.Area = Area(re);
            ca.Perimeter = Perimeter(re);
            return ca;
        }
        static void Main(string[] args)
        {
            //Rectangle re = new Rectangle();
            //Input(out re);
            //Console.WriteLine($"Area : {GetAreaPerimeter(re).Area}");
            //Console.WriteLine($"Perimeter : {GetAreaPerimeter(re).Perimeter}");
            Rectangle[] arrRe = new Rectangle[5];
            for(int i =0; i< arrRe.Length;i++)
            {
                Console.WriteLine($"Input rectangle nunber {i}");
                Input( out arrRe[i]);
                Console.WriteLine($"Area rectangle nunber {i} : {GetAreaPerimeter(arrRe[i]).Area}");
                Console.WriteLine($"Perimeter rectangle nunber {i} : {GetAreaPerimeter(arrRe[i]).Perimeter}");
                Console.WriteLine();
            }    
        }
    }
    public struct Calculator
    {
        public double Area;
        public double Perimeter;
    }
}
