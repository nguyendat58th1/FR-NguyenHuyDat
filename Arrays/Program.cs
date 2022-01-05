using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = GetArray();
            Ouput(arr);
            Sort(arr);
            Console.WriteLine();
            Ouput(arr);

        }
        static int[] GetArray()
        {
            int[] arr = new int[] { 1, 6, 7, 2, 1, 4, 8};
            return arr;
        }

        static void Sort(int[] arr)
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
        static void Ouput(int[] arr)
        {
            foreach(var i in arr)
            {
                Console.Write($"{i} ");
            }    
        }
    }
}
