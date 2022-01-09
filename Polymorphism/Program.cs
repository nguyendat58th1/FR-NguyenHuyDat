using Polymorphism.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //ListLabEmployee lstLabEmployee = new ListLabEmployee();
            //lstLabEmployee.NhapList();
            //lstLabEmployee.XuatList();
            //Console.WriteLine();
            //ListManager lstLManager = new ListManager();
            //lstLManager.NhapList();
            //lstLManager.XuatList();
            Console.WriteLine();
            ListScientist lstLScientist = new ListScientist();
            lstLScientist.NhapList();
            lstLScientist.XuatList();
        }
    }
    class ListLabEmployee : IHandleList
    {
        List<LabEmployee> lstLabEmployee;

        public ListLabEmployee()
        {
            lstLabEmployee = new List<LabEmployee>();
        }
        public void NhapList()
        {
            Console.Write("Nhập số lượng nhân viên phòng thí nghiệm : ");
            int n = Int32.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                LabEmployee labEmp = new LabEmployee();
                labEmp.Nhap();
                lstLabEmployee.Add(labEmp);
            }    

        }

        public void XuatList()
        {
            Console.WriteLine("Danh sách nhân viên phòng thí nghiệm");
            for(int i =0; i<lstLabEmployee.Count;i++)
            {
                lstLabEmployee[i].Xuat();
            }    
        }
    }
    class ListManager : IHandleList
    {
        List<Manager> lstManager;

        public ListManager()
        {
            lstManager = new List<Manager>();
        }
        public void NhapList()
        {
            Console.Write("Nhập số lượng nhân viên quản lý : ");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Manager manager = new Manager();
                manager.Nhap();
                lstManager.Add(manager);
            }

        }

        public void XuatList()
        {
            Console.WriteLine("Danh sách nhân viên quản lý");
            for (int i = 0; i < lstManager.Count; i++)
            {
                lstManager[i].Xuat();
            }
        }
    }

    class ListScientist : IHandleList
    {
        List<Scientist> lstScientist;

        public ListScientist()
        {
            lstScientist = new List<Scientist>();
        }
        public void NhapList()
        {
            Console.Write("Nhập số lượng nhà khoa học : ");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Scientist scientist = new Scientist();
                scientist.Nhap();
                lstScientist.Add(scientist);
            }

        }

        public void XuatList()
        {
            Console.WriteLine("Danh sách nhà khoa học");
            for (int i = 0; i < lstScientist.Count; i++)
            {
                lstScientist[i].Xuat();
            }
        }
    }
}
