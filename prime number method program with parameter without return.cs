class Demo
{
    static string P1(int num)
    {
        int i = 2; string result;
        bool flag = true;
        while (i <= num / 2)
        {
            if (num % i == 0)
            {

                flag = false;
                break;
            }
            i++;

        }
        if (flag == true)
            result = ("number is prime");
        else
            result = (" Number is not Prime");
        return result;
    }
    static void Main()
    {
        System.Console.WriteLine("Enter the Number");
        int num = System.Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine(P1(num));
    }
}

