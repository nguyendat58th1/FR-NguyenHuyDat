using System;
using System.Collections;
using System.Collections.Generic;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Peter", 18, 10);
            Student st2 = new Student();
            st.Output();
            st2.Output();
            st.SaySomething();
            List<Student> lstStudent = new List<Student>();
            ArrayList arrlistStudent = new ArrayList();
            InputListStudent(lstStudent);
            Console.WriteLine();
            OutputListStudent(lstStudent);
            InputArrayListStudent(arrlistStudent);
            Console.WriteLine();
            OutputArrayListStudent(arrlistStudent);
        }
        static void InputListStudent(List<Student> lstStudent)
        {
            Console.Write("Input the number of students (use List) :");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Student st = new Student();
                Console.WriteLine($"Student number {i + 1}: ");
                Console.Write("Name : ");
                st.Name = Console.ReadLine();
                Console.Write("Age : ");
                st.Age = Int32.Parse(Console.ReadLine());
                Console.Write("Score : ");
                st.Score = Int32.Parse(Console.ReadLine());
                lstStudent.Add(st);
            }
        }
        static void OutputListStudent(List<Student> lstStudent)
        {
            foreach (var item in lstStudent)
            {
                item.Output();
            }
        }

        static void InputArrayListStudent(ArrayList arrlstStudent)
        {
            Console.Write("Input the number of students (use ArrayList) :");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Student st = new Student();
                Console.WriteLine($"Student number {i + 1}: ");
                Console.Write("Name : ");
                st.Name = Console.ReadLine();
                Console.Write("Age : ");
                st.Age = Int32.Parse(Console.ReadLine());
                Console.Write("Score : ");
                st.Score = Int32.Parse(Console.ReadLine());
                arrlstStudent.Add(st);
            }
        }
        static void OutputArrayListStudent(ArrayList arrlstStudent)
        {
            foreach (Student item in arrlstStudent)
            {
                item.Output();
            }
        }
    }
    class Student : People
    {
        public int Score { get; set; }
        public Student() : base()
        {
            this.Score = 0;
        }

        public Student(string name, int age, int score) : base(name, age)
        {
            this.Score = score;
        }

        public void Output()
        {
            Console.WriteLine($"Name : {this.Name}  Age : {this.Age}  Score : {this.Score}");
        }
        public override void SaySomething()
        {
            Console.WriteLine("student");
        }
    }
    abstract class People
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public People()
        {
            this.Name = "Unknown";
            this.Age = 0;
        }

        public People(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public virtual void SaySomething()
        {
            Console.WriteLine("avv");
        }
    }
}
