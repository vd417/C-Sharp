class Demo
{
    static void Cal(int x, int y, out int sum, out int minus, out int mul, out int div)
    {
        sum = x + y;
        minus = x - y;
        mul = x * y;
        div = x / y;
    }
    static void Main()
    {
        int s, m, mu, d;
        Cal(10, 2, out s, out m, out mu, out d);
        System.Console.WriteLine("sum is: " +s);
        System.Console.WriteLine("minus is: " + m);
        System.Console.WriteLine("mul is: " + mu);
        System.Console.WriteLine("div is: " + d);


    }
}


