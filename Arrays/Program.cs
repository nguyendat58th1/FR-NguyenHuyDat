using System;
using System.Text;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n,k;
            int[] arr = GetArray();
            Ouput(arr);
            SortTang(arr);
            Ouput(arr);

            Console.Write("Nhập số phần tử mảng : ");
            n = Int32.Parse(Console.ReadLine());
            int[] arr2 = new int[n];
            Console.WriteLine();
            Input(arr2);
            Ouput(arr2);
            if(Compare2Arrays(arr, arr2))
                Console.WriteLine("2 mảng giống nhau");
            else
                Console.WriteLine("2 mảng khác nhau");
            SortGiam(arr2);
            Ouput(arr2);
            SortTang(arr2);
            Ouput(arr2);

            Console.Write("Nhập vị trí phần tử muốn xóa : ");
            do
                k = Int32.Parse(Console.ReadLine());
            while (k < 0 || k > n);
            Remove(ref arr2, k);
            Ouput(arr2);

            int[,] arr2D = new int[3, 3];
            InputMang2Chieu(arr2D);
            Ouputmang2Chieu(arr2D);
        }
        static int[] GetArray()
        {
            int[] arr = new int[] { 1, 6, 7, 2, 1, 4, 8};
            return arr;
        }

        static void SortTang(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] > arr[j])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
        }

        static void SortGiam(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] < arr[j])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
        }
        static void Ouput(params int[] arr)
        {
            foreach(var i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        static void Input(params int[] arr)
        {
            Console.WriteLine($"Nhập mảng :");
            for(int i =0; i < arr.Length; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }
        }

        static void InputMang2Chieu(int[,] arr)
        {
            Console.WriteLine($"Nhập mảng 2 chiều :");
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j ++)
                {
                    Console.Write($"Nhập A[{i}][{j}] : ");
                    arr[i,j] = Int32.Parse(Console.ReadLine());
                }
        }

        static void Ouputmang2Chieu( int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }    
        }
        static void Remove(ref int[] arr, int k)
        {
            for(int i = k; i<arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
        }
        static bool Compare2Arrays(int[] arr1, int[] arr2)
        {
            if(arr1.Length == arr2.Length)
            {
                for(int i=0;i <arr2.Length;i++)
                {
                    if(arr1[i] == arr2[i])
                    {
                        return true;
                    }    
                }    
            }
            return false;
        }
    }
}
