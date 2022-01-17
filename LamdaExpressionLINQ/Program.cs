using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LamdaExpressionLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Employee> lstEmp = new List<Employee>() {
                new Employee {
                    ID = 1,
                    Name = "Nam",
                    DoB = new DateTime(1998,4,1)
                },
                new Employee {
                    ID = 2,
                    Name = "Huy",
                    DoB = new DateTime(1998,4,1)
                },
                new Employee {
                    ID = 20,
                    Name = "Dat",
                    DoB = new DateTime(1998,4,1)
                },
                new Employee {
                    ID = 13,
                    Name = "Thang",
                    DoB = new DateTime(1993,4,1)
                },
                new Employee {
                    ID = 15,
                    Name = "Duong",
                    DoB = new DateTime(1998,4,1)
                },
                new Employee {
                    ID = 4,
                    Name = "Hieu",
                    DoB = new DateTime(1998,4,1)
                },
                      new Employee {
                    ID = 4,
                    Name = "Cao",
                    DoB = new DateTime(1998,4,1)
                },
                            new Employee {
                    ID = 32,
                    Name = "Chien",
                    DoB = new DateTime(1993,4,1)
                },
            };
            Console.WriteLine("Danh sách nhân viên : ");
            foreach (var i in lstEmp)
            {
                Ouput(i);
            }
            Console.WriteLine("Nhân viên có ID trên 10");
            FindEmployeeHasIDGreaterThan10(lstEmp);
            Console.WriteLine("Nhân viên có ID trên 10 và tên bắt đầu với 'C' ");
            FindEmployeeHasIDGreaterThan10AndNameStartWithC(lstEmp);
            Console.WriteLine("Nhân viên có năm sinh = 1992 ");
            FindFirstEmployeeHasYearOfBirthEqual1992(lstEmp);



        }
        static void Ouput(Employee emp)
        {
            Console.Write($"{emp.ID}   {emp.Name}   {emp.DoB}");
            Console.WriteLine();
        }
        static void FindEmployeeHasIDGreaterThan10AndNameStartWithC(List<Employee> lstEmp)
        {
            lstEmp = lstEmp.Where(x=> x.ID > 10 && x.Name.StartsWith('C')).ToList();
            foreach (var i in lstEmp)
            {
                Ouput(i);
            }
        }
        static void FindEmployeeHasIDGreaterThan10(List<Employee> lstEmp)
        {
            lstEmp = lstEmp.Where(x => x.ID > 10).ToList();
            foreach (var i in lstEmp)
            {
                Ouput(i);
            }
        }
        static void FindFirstEmployeeHasYearOfBirthEqual1992(List<Employee> lstEmp)
        {
            try
            {
                var emp = lstEmp.Where(x => x.DoB.Year == 1992).FirstOrDefault();
                if (emp == null)
                {
                    throw new Exception("Không tồn tại ai sinh năm 1992");
                }
                Ouput(emp);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DoB { get; set; }
    }
}
