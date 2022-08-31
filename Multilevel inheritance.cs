using System;

namespace Multilevel_inheritance
{
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
        void process()
        {
            Console.WriteLine("I m child");
            this.Show();
            this.Display();
        }
        static void Main()
        {
            Demo d = new Demo();
            d.process();

        }
    }
}