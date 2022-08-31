using System;
class Mix
{
    protected void show()
    {
        Console.WriteLine("Hello");
    }
}
class Demo : Mix
{
    static void Main()
    {
        Demo d = new Demo();
        d.show();
    }
}