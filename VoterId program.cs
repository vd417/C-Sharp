using System;
class VoterId

{
    static void Main()
    {
        Console.WriteLine("Enter the age");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the citizenship");
        string citizenship = Convert.ToString(Console.ReadLine());
        if (citizenship=="Indian")
        
            if (age >= 18)
                Console.WriteLine("Voter is Valid");
            else
                Console.WriteLine("Voter is Invalid due to age");
        else
                Console.WriteLine("Voter is not Valid");
        }

    }

