class Pattern
{
    static void M1(int ctr)
    {
        ctr = 1;
        while (ctr <= 3)
        {
            int ptr = 1;
            while (ptr <= ctr)
            {
                System.Console.Write("A");
                ptr++;
            }
            System.Console.WriteLine();
            ctr++;
        }

    }
    static void Main()
    {
        int ctr = 1;
        M1(ctr);

    }
}

