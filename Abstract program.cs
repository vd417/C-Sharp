using System;
abstract class Test
{
    public void Show()
    {
        Console.WriteLine("Hello");
    }
}
class Demo : Test
{
    static void Main(string[]args)
    {
        Test t = new Demo();
        t.Show();
    }
}