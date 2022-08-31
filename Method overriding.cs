using System;
class Parent
{
    protected void Property()
    {
        Console.WriteLine("10000000 cash/Gold/Land/Car");
    }
    protected virtual void Marry()
    {
        Console.WriteLine("father Choice");
    }


    static void Main()
    {
        Parent parent = new Parent();
        parent.Property();
        parent.Marry();
  

    }
}