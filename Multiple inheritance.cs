using System;
class Test
{
    protected void Display()
    {
        Console.WriteLine("Hi");
    }
}
class Mix : Test
{
    protected void Show()
    {
        Console.WriteLine("Hello");
    }
}
class Demo : Mix
{
    static void Main()
    {
        Demo d = new Demo();
        d.Show();
        d.Display();
    }
}
