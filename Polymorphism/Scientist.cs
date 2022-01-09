using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Scientist : Manager
    {
        public int SoBaiBao { get; set; }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Số bài báo đã công bố : ");
            this.SoBaiBao = Int32.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.Write($"Số bài báo: {this.SoBaiBao}");
            Console.WriteLine();
        }
    }
}
