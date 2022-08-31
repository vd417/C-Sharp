using System;
class Parent
{
    protected virtual void Marry()
    {
        Console.WriteLine("Father choice");

    }
}
class Child : Parent
{
    protected override void Marry()
    {
        base.Marry();
        Console.WriteLine("After 3 year");
    }

    static void Main()
    {
        Child c1 = new Child();
        c1.Marry();
    }
}