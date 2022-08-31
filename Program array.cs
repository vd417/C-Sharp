using System;
namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the array size");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int i = 0;
            do
            {
                Console.WriteLine("enter the value");
                arr[i] = int.Parse(Console.ReadLine());
                i++;

            }
            while (i <= arr.Length);
            Console.WriteLine("-------------");
            int sum = 0;
            i = 0;
            do
            {
                sum = sum + arr[i];
                i++;
            }
            while (i < arr.Length);
            Console.WriteLine(sum);

        }
    }
}
    
