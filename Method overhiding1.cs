using System;
class Parent
{
    public static void Marry()
    {
        Console.WriteLine("Parent");

    }
}
class Child : Parent
{
    public static new void Marry()
    {
        Console.WriteLine("Child");
    }
    static void Main()
    {
        Marry();
    }
    }
