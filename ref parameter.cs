class NamedParameter
{
    static void Display(int empNo, string empName, double empSal)
    {
        System.Console.WriteLine(empNo);
        System.Console.WriteLine(empName);
        System.Console.WriteLine(empSal);
    }
    static void Main()
    {
        Display(empSal:24000,empNo:101,empName:"Sanjeev");
    }
}