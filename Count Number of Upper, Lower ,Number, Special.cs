using System;
class Demo
{
    static void CountString(string name)
    {
        int len = name.Length;
        int UpperLetter = 0;
        int LowerLetter = 0;
        int Number = 0;
        int SpecialCharacter=0;

        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] >= 'A' && name[i] <= 'Z')
                UpperLetter++;
            else if (name[i] >= 'a' && name[i] <= 'z')
                LowerLetter++;
            else if (name[i] >= '0' && name[i] <= '9')
                Number++;
            else
                SpecialCharacter++;
        }
        Console.WriteLine("Length(No. of Character) : {0} \nUpperLetter : {1}  \nLowerLetter : {2} \nNumber : {3}  \nSpecialCharacter : {4}", len,UpperLetter, LowerLetter, Number, SpecialCharacter);
    }

    static void Main()
    {
        Console.Write("Enter the String you want to reverse : ");
        string name = Console.ReadLine();

        CountString(name);
    }

}