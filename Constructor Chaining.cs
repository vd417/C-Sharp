using System;
namespace Rajeev {
    class G
    {
        public G()
        {
            Console.WriteLine("Grand");
        }
    }
    class P : G
    {
        public P()
        {
            Console.WriteLine("Parent");
        }
    }
    class C : P
    {
        public C()
        {
            Console.WriteLine("Child");
        }

        void Show()
        {
            Console.WriteLine("Hello");
        }
        static void Main(string[] args)
        {
            C obj = new C();
            obj.Show();
        }
    }
}

