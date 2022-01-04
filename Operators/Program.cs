using System;
using System.Collections.Generic;
using System.Text;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();
            PhanSo ps3 = new PhanSo();
            ArrayPhanSo arrPS = new ArrayPhanSo();
            Console.WriteLine("Nhập phân số 1 : ");
            ps1.Input();
            Console.WriteLine("Nhập phân số 2 : ");
            ps2.Input();

            if (ps3.TinhTong(ps1, ps2).tuSo % ps3.TinhTong(ps1, ps2).mauSo == 0
                && ps3.TinhTong(ps1, ps2).tuSo >= ps3.TinhTong(ps1, ps2).mauSo)
                Console.WriteLine($"Tổng 2 phân số : { ps3.TinhTong(ps1, ps2).tuSo / ps3.TinhTong(ps1, ps2).mauSo}");
            else
                Console.WriteLine($"Tổng 2 phân số : { ps3.TinhTong(ps1, ps2).tuSo} / {ps3.TinhTong(ps1, ps2).mauSo}");

            if (ps3.TinhHieu(ps1, ps2).tuSo % ps3.TinhHieu(ps1, ps2).mauSo == 0
                && ps3.TinhHieu(ps1, ps2).tuSo >= ps3.TinhHieu(ps1, ps2).mauSo)
                Console.WriteLine($"Hiệu 2 phân số : { ps3.TinhHieu(ps1, ps2).tuSo / ps3.TinhHieu(ps1, ps2).mauSo}");
            else
                Console.WriteLine($"Hiệu 2 phân số : { ps3.TinhHieu(ps1, ps2).tuSo} / {ps3.TinhHieu(ps1, ps2).mauSo}");

            if (ps3.TinhTich(ps1, ps2).tuSo % ps3.TinhTich(ps1, ps2).mauSo == 0
                && ps3.TinhTich(ps1, ps2).tuSo >= ps3.TinhTich(ps1, ps2).mauSo)
                Console.WriteLine($"Tích 2 phân số : { ps3.TinhTich(ps1, ps2).tuSo / ps3.TinhTich(ps1, ps2).mauSo}");
            else
                Console.WriteLine($"Tích 2 phân số : { ps3.TinhTich(ps1, ps2).tuSo} / {ps3.TinhTich(ps1, ps2).mauSo}");

            if (ps3.TinhThuong(ps1, ps2).tuSo % ps3.TinhThuong(ps1, ps2).mauSo == 0
                && ps3.TinhThuong(ps1, ps2).tuSo >= ps3.TinhThuong(ps1, ps2).mauSo)
                Console.WriteLine($"Thương 2 phân số : { ps3.TinhThuong(ps1, ps2).tuSo / ps3.TinhThuong(ps1, ps2).mauSo}");
            else
                Console.WriteLine($"Thương 2 phân số : { ps3.TinhThuong(ps1, ps2).tuSo} / {ps3.TinhThuong(ps1, ps2).mauSo}");

            arrPS.InputMangPhanSo();
            arrPS.OutputMangPhanSo();
            arrPS.SortTangDan();
            Console.WriteLine();
            Console.WriteLine("Mảng sau khi sắp xếp tăng dần : ");
            arrPS.OutputMangPhanSo();
            arrPS.SortGiamDan();
            Console.WriteLine();
            Console.WriteLine("Mảng sau khi sắp xếp giảm dần : ");
            arrPS.OutputMangPhanSo();
        }
    }

    class ArrayPhanSo
    {
        PhanSo[] arrPhanSo;
        int n;
        public ArrayPhanSo()
        {
 
        }
        public void InputMangPhanSo()
        {
            Console.Write("Nhập số lượng phân số : ");
            n = Int32.Parse(Console.ReadLine());
            arrPhanSo = new PhanSo[n];
            for (int i = 0; i < arrPhanSo.Length; i++)
            {
                Console.WriteLine($"Phân số thứ {i} : ");
                arrPhanSo[i] = new PhanSo();
                arrPhanSo[i].Input();
            }
        }
        public void OutputMangPhanSo()
        {
            for (int i = 0; i < arrPhanSo.Length; i++)
            {
                arrPhanSo[i].Output();
            }
        }
        public void SortTangDan()
        {
            for(int i=0; i<arrPhanSo.Length - 1; i++)
                for(int j=i+1; j< arrPhanSo.Length; j++)
                    if( (float)arrPhanSo[i].tuSo/arrPhanSo[i].mauSo > (float) arrPhanSo[j].tuSo/arrPhanSo[j].mauSo)
                    {
                        var temp = arrPhanSo[i];
                        arrPhanSo[i] = arrPhanSo[j];
                        arrPhanSo[j] = temp;
                    }    
        }

        public void SortGiamDan()
        {
            for (int i = 0; i < arrPhanSo.Length - 1; i++)
                for (int j = i + 1; j < arrPhanSo.Length; j++)
                    if ((float)arrPhanSo[i].tuSo / arrPhanSo[i].mauSo < (float)arrPhanSo[j].tuSo / arrPhanSo[j].mauSo)
                    {
                        var temp = arrPhanSo[i];
                        arrPhanSo[i] = arrPhanSo[j];
                        arrPhanSo[j] = temp;
                    }
        }
    }
    class PhanSo
    {
        public int tuSo;
        public int mauSo;

        public PhanSo()
        {
        
        }

        public void Input()
        {
            Console.Write("Tử số = ");
            this.tuSo = Int32.Parse(Console.ReadLine());
            do
            {
                Console.Write("Mẫu số = ");
                this.mauSo = Int32.Parse(Console.ReadLine());
            }
            while (this.mauSo == 0);
        }

        public void Output()
        {
            if (tuSo % mauSo == 0 && tuSo >= mauSo)
                Console.Write($"{tuSo / mauSo}  ");
            else
                Console.Write($"{ tuSo}/{mauSo}  ");
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

        public static PhanSo operator +(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps3 = new PhanSo();
            ps3.tuSo = ps1.tuSo * ps2.mauSo + ps2.tuSo * ps1.mauSo;
            ps3.mauSo = ps1.mauSo * ps2.mauSo;
            int ucln = TinhUcln(ps3.tuSo, ps3.mauSo);
            ps3.tuSo = ps3.tuSo / ucln;
            ps3.mauSo = ps3.mauSo / ucln;
            return ps3;
        }

        public static PhanSo operator -(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps3 = new PhanSo();
            ps3.tuSo = ps1.tuSo * ps2.mauSo - ps2.tuSo * ps1.mauSo;
            ps3.mauSo = ps1.mauSo * ps2.mauSo;
            int ucln = TinhUcln(ps3.tuSo, ps3.mauSo);
            ps3.tuSo = ps3.tuSo / ucln;
            ps3.mauSo = ps3.mauSo / ucln;
            return ps3;
        }

        public static PhanSo operator *(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps3 = new PhanSo();
            ps3.tuSo = ps1.tuSo * ps2.tuSo;
            ps3.mauSo = ps1.mauSo * ps2.mauSo;
            int ucln = TinhUcln(ps3.tuSo, ps3.mauSo);
            ps3.tuSo = ps3.tuSo / ucln;
            ps3.mauSo = ps3.mauSo / ucln;
            return ps3;
        }
        public static PhanSo operator /(PhanSo ps1, PhanSo ps2)
        {
            PhanSo ps3 = new PhanSo();
            ps3.tuSo = ps1.tuSo * ps2.mauSo;
            ps3.mauSo = ps1.mauSo * ps2.tuSo;
            int ucln = TinhUcln(ps3.tuSo, ps3.mauSo);
            ps3.tuSo = ps3.tuSo / ucln;
            ps3.mauSo = ps3.mauSo / ucln;
            return ps3;
        }
        public PhanSo TinhTong(PhanSo ps1, PhanSo ps2)
        {
            return ps1 + ps2;
        }
        public PhanSo TinhHieu(PhanSo ps1, PhanSo ps2)
        {
            return ps1 - ps2;
        }
        public PhanSo TinhTich(PhanSo ps1, PhanSo ps2)
        {
            return ps1 * ps2;
        }
        public PhanSo TinhThuong(PhanSo ps1, PhanSo ps2)
        {
            return ps1 / ps2;
        }
    }
}
