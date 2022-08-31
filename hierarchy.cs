using System;

namespace N1
{
    class Parent
    {
        protected void Display()
        {
            Console.WriteLine("I m parent");
        }
    }
    class child1 : Parent
    {
        internal void Show()
        {
            this.Display();
            Console.WriteLine("I m Child-1");
        }
    }
    class child2 : Parent
    {
        internal void Show()
        {
            this.Display();
            Console.WriteLine("I m Child-2");
        }
    }
    class Demo
    {
        static void Main()
        {
            child1 c1 = new child1();
            child2 c2 = new child2();
            c1.Show();
            c2.Show();

        }
    }
}
      
