using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Peter", 18 , 10);
            st.Output();
        }
    }
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Score { get; set; }
        public Student()
        {
            this.Name = "Unknown";
            this.Age = 0;
            this.Score = 0;
        }

        public Student(string name, int age, int score)
        {
            this.Name = name;
            this.Age = age;
            this.Score = score;
        }

        public void Output()
        {
            Console.WriteLine($"{this.Name} {this.Age} {this.Score}");
        }
    }
}
