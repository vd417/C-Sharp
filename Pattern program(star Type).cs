class Pttern
{
    static void Main()
    {
        char ctr = 'A';
        while (ctr <= 'D')
        {
            char ptr = 'D';
            while (ptr >= ctr)
            {
                System.Console.Write("ctr");
                ptr--;
            }
            
            System.Console.WriteLine();
            ctr++;


        }
    }
    }

