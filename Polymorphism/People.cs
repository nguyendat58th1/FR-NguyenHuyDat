using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public abstract class People
    {
        public string HoTen { get; set; }
        public DateTime NamSinh { get; set; }
        public string BangCap { get; set; }
        public float Luong { get; set; }

        public virtual void Nhap()
        {
            Console.Write("Nhập tên :");
            this.HoTen = Console.ReadLine();
            int day;
            do
            {
                Console.Write("Ngày sinh: ");
                day = int.Parse(Console.ReadLine());
            }
            while (day <= 0 || day>31);

            int month;
            do
            {
                Console.Write("Tháng sinh: ");
                month = int.Parse(Console.ReadLine());
            }
            while (month <= 0 || month > 12);

            int year;
            do
            {
                Console.Write("Năm sinh: ");
                year = int.Parse(Console.ReadLine());
            }
            while (year <= 0);


            this.NamSinh = new DateTime(year, month, day);
            Console.Write("Bằng cấp :");
            this.BangCap = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.Write($"Tên: { this.HoTen}  Năm sinh: { this.NamSinh}  Bằng cấp: { this.BangCap}  ");
        }
    }
}
