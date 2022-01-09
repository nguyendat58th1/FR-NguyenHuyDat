using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Manager : People
    {
        public string ChucVu { get; set; }
        public int SoNgayCong { get; set; }
        public float BacLuong { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Chức vụ : ");
            this.ChucVu = Console.ReadLine();
            Console.Write("Số ngày công : ");
            this.SoNgayCong = Int32.Parse(Console.ReadLine());
            Console.Write("Bậc lương : ");
            this.BacLuong = float.Parse(Console.ReadLine());
            this.Luong = this.BacLuong * this.SoNgayCong;

        }

        public override void Xuat()
        {
            base.Xuat();
            Console.Write($"Chức vụ: {this.ChucVu}  Số ngày công: {this.SoNgayCong}  Bậc lương: {this.BacLuong}  Lương: { this.Luong}  ");
            Console.WriteLine();
        }
    }
}
