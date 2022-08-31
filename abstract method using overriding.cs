using System;

namespace Abstract_using_override_Method
{
    abstract class Test
    {
        public abstract void Show();
    }
    class Demo : Test
    {
        public override void Show()
        {
            Console.WriteLine("Hello");
        }
        static void Main(string[]args)
        {
            Test t = new Demo();
            t.Show();
        }
    }
      
}
