class PerfomOperation
{
    static int M1(int n1, int n2, char choice)
    {
        int result = 0;
        if(choice=='+')
                result = n1 + n2;
                
        else if (choice == '-')
            result = n1 - n2;
                
        else if (choice == '*')
            result = n1 * n2;
               
        else if (choice == '/')
            result = n1 / n2;
               
        return result;
    }
    static void Main()
    {
        System.Console.WriteLine("Enter the first number");
        int n1 = System.Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine("Enter the second number");
        int n2 = System.Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine("Enter the operator");
        char choice = System.Convert.ToChar(System.Console.ReadLine());
        System.Console.WriteLine(M1(n1, n2, choice));
    }
}
