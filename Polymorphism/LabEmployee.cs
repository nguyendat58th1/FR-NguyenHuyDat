using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class LabEmployee : People
    {
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Lương : ");
            this.Luong = Int32.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.Write($"Lương: {this.Luong}");
            Console.WriteLine();
        }
    }
}
