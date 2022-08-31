using System;
class Parent
{
    protected void Marry()
    {
        Console.WriteLine("Parent choice");
    }
}
class Child : Parent
{
    protected new void Marry()
    {
        Console.WriteLine("Child Choice");
    }
    static void Main()
    {
        Child c = new Child();
        c.Marry();
    }
}



