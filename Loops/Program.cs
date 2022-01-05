using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n,a,b;
            List<Student> lstStudents = new List<Student>() {
                new Student {Name = "Peter", Score = 10},
                new Student {Name = "Linda", Score = 5},
                new Student {Name = "Eden", Score = 6},
                new Student {Name = "Rick", Score = 8},
                new Student {Name = "Ben", Score = 9},
                new Student {Name = "Hugh", Score = 10},
            };
            Console.Write("Nhập n :");
            n = Int32.Parse(Console.ReadLine());
            if (CheckPrimeNumber(n))
                Console.WriteLine($"{n} là số nguyên tố");
            else
                Console.WriteLine($"{n} không là số nguyên tố");
            Console.WriteLine();
            if (CheckPerfectNumber(n))
                Console.WriteLine($"{n} là số hoàn hảo");
            else
                Console.WriteLine($"{n} không là số hoàn hảo");
            Console.WriteLine();
            for(int i=0; i<n; i++)
            {
                Console.Write($"{Fibonacci(i)} ");
            }    
            Console.WriteLine();
            Console.Write("Nhập a :");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Nhập b :");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Bội chung nhỏ nhất của a và b : {TinhBcnn(a, b)}");
            Console.WriteLine();
            ForEachExample(lstStudents);
            Console.WriteLine();
            WhileExample();
            Console.WriteLine();
            DoWhileExample(ref lstStudents);
        }
        public static Boolean CheckPrimeNumber(int n)
        {
            // so nguyen n < 2 khong phai la so nguyen to
            if (n < 2)
            {
                return false;
            }
            // check so nguyen to khi n >= 2
            int squareRoot = (int)Math.Sqrt(n);
            int i;
            for (i = 2; i <= squareRoot; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static Boolean CheckPerfectNumber(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            if (sum == n)
            {
                return true;
            }
            return false;
        }

        public static int Fibonacci(int n)
        {
             int f0 = 0;
            int f1 = 1;
            int fn = 1;
            int i;
 
            if (n < 0)
            {
                return -1;
            }
            else if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                for (i = 2; i < n; i++)
                {
                    f0 = f1;
                    f1 = fn;
                    fn = f0 + f1;
                }
            }
            return fn;
        }

        public static int TinhUcln(int a, int b)
        {
            int r = 1;
            while (r != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        public static int TinhBcnn(int a, int b)
        {
            int ucln = TinhUcln(a, b);
            return a*b/ucln;
        }
        public static void ForEachExample(List<Student> listStudents)
        {
            //tìm hs điểm cao nhất 
            int max = 0;
            foreach(var item in listStudents)
            {
                if (item.Score > max)
                    max = item.Score;
            }
            Console.WriteLine("Học sinh có điểm cao nhất : ");
            foreach (var item in listStudents)
            {
                if (item.Score == max)
                    Console.WriteLine(item.Name);
            }
        }
        public static void WhileExample()
        {
            int n;
            Console.Write("Nhập số nguyên tố : ");
            n = Int32.Parse(Console.ReadLine());
            while (!CheckPrimeNumber(n))
            {
                Console.Write("Nhập lại số nguyên tố : ");
                n = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{n} là số nguyên tố ");
        }
        public static void DoWhileExample(ref List<Student> students)
        {
            Student st = new Student();
            Console.Write("Nhập tên học sinh mới : ");
            st.Name = Console.ReadLine();
            do
            {
                Console.Write("Nhập điểm học sinh mới : ");
                st.Score = Int32.Parse(Console.ReadLine());
            }
            while (st.Score < 0);
            students.Add(st);
            Console.WriteLine("Danh sách học sinh :");
            foreach(var item in students)
            {
                Console.WriteLine($"{item.Name} {item.Score}");
            }    
        }
    }
    class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
}
