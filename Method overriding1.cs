using System;
class Grand
{
    protected void Marry()
    {
        Console.WriteLine("Grand Choice");
    }
}
   class Parent : Grand
{ 
    protected virtual new void Marry()
    {
        Console.WriteLine("Parent Choice");
    }
    }
     class Child : Parent
   {
      protected override void Marry()
    {
        Console.WriteLine("Child choice");
    }


    static void Main()
    {
        Child child = new Child();
        Child.Marry();
      


    }
}
