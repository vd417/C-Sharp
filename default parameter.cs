class DefaultParameter
{
    static string Cal(int x, int y, string choice = "+")
    {
        string res = " ";
        if (choice == "+")
            res = System.Convert.ToString(x + y);
        else if (choice == "-")
            res = System.Convert.ToString(x - y);
        else if (choice == "+")
            res = System.Convert.ToString(x * y);
        else if (choice == "+")
            res = System.Convert.ToString(x / y);
        else
            res = "Invalid Oparator";
        return res;
    }
    static void Main()
    {
        string a = Cal(10, 2);
        System.Console.WriteLine("res is:" + a);
    }
}
