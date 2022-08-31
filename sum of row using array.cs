using System;
class Sum1
{
    static void Main1(string[]args)
    {
        Console.WriteLine("Enter the base array: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the sub array: ");
        int b = int.Parse(Console.ReadLine());
        int[,] arr = new int[a, b];
        int i = 0;
        while (i < arr.GetLength(0))
        {
            int j = 0;
            while (j < arr.GetLength(1))
            {
                Console.WriteLine("Enter the Size: ");
                arr[i, j] = int.Parse(Console.ReadLine());
                j++;

            }
            i++;
        }
        Console.WriteLine("-----");
        i = 0;
        while (i < arr.GetLength(0))
        {
            int j = 0;
            while (j < arr.GetLength(1))
            {
                Console.Write(arr[i, j] + " ");
                j++;
            }
            i++;

            Console.WriteLine();

        }
        i = 0;
        while (i < arr.GetLength(0))
        {
            int sum = 0;
            int j = 0;
            while(j<arr.GetLength(1))
            {
                sum = sum + arr[j, i];
                j++;
            }
            Console.WriteLine("sum of col{0}is{1}", i + 1, sum);
            i++;

        }
        }
    }
