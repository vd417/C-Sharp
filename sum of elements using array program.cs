using System;
namespace array
{
    class Program
    {
        static void Main(string[] arg)
        {
            int[,] arr;
            System.Console.WriteLine("enter base array size: ");
            int b = int.Parse(Console.ReadLine());
            System.Console.WriteLine("enter sub array size: ");
            int c = int.Parse(Console.ReadLine());
            arr = new int[b, c];
            for (int i = 0; i <= arr.GetLength(0); i++)
            {
                for (int j = 0; j <= arr.GetLength(1); j++)
                {
                    Console.WriteLine("enter data");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.WriteLine(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
    










           