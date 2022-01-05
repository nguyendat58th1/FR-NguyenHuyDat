using System;

namespace Struct
{
    public struct Rectangle
    {
        public double width;
        public double height;

        public void Input()
        {
            Console.Write("Height :");
            height = Double.Parse(Console.ReadLine());
            Console.Write("Width : ");
            width = Double.Parse(Console.ReadLine());
        
        }
        //public static double Area(Rectangle re)
        //{
        //    return re.Height * re.Width;
        //}

        //public static double Perimeter(Rectangle re)
        //{
        //    return re.Height + re.Width;
        //}

        public static Calculator GetAreaPerimeter(Rectangle re)
        {
            Calculator ca = new Calculator();
            ca.Area = re.height * re.width;
            ca.Perimeter = re.height + re.width;
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
                arrRe[i].Input();
                Console.WriteLine($"Area rectangle nunber {i} : {GetAreaPerimeter(arrRe[i]).Area}");
                Console.WriteLine($"Perimeter rectangle nunber {i} : {GetAreaPerimeter(arrRe[i]).Perimeter}");
                Console.WriteLine();
            }    
        }
    }
    public struct Calculator
    {
        public double Area { get; set; }
        public double Perimeter { get; set; }
    }
}
