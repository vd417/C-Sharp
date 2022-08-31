using System;
class Address
{
    private int houseNo;
    private string houseName;
    private int pinCode;

    public Address(int houseNo, string houseName, int pinCode)
    {
        this.houseNo = houseNo;
        this.houseName = houseName;
        this.pinCode = pinCode;
    }
    public int GetHouseNo()
    {
        return houseNo;
    }
    public string GetHouseName()
    {
        return houseName;
    }
    public int GetPinCode()
    {
        return pinCode;
    }
    public override string ToString()
    {
        return houseNo + " " + houseName + " " + pinCode;
    }
}

class Employee
{
    private int empNo;
    private string empName;
    private double empSal;
    private Address address;

    public Employee(int empNo, string empName, double empSal)
    {
        this.empNo = empNo;
        this.empName = empName;
        this.empSal = empSal;

    }
    public int GetEmpNo()
    {
        return empNo;
    }
    public string GetEmpName()
    {
        return empName;
    }
    public double GetEmpSal()
    {
        return empSal;
    }
}

class MainMethod
{
    static void Main()
    {
        Console.Write("Enter the Employee Number:");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter the Employee Name:");
        string Name = Console.ReadLine();
        Console.Write("Enter the Employee Salery:");
        double Salery = double.Parse(Console.ReadLine());
        Console.Write("Enter the Employee House Number:");
        int HouseNo = int.Parse(Console.ReadLine());
        Console.Write("Enter the Employee House Name:");
        string HouseName = Console.ReadLine();
        Console.Write("Enter the Employee Pin Code:");
        int PinCode = int.Parse(Console.ReadLine());

        Employee employee = new Employee(num, Name, Salery);

        Address address = new Address(HouseNo, HouseName, PinCode);



        Console.WriteLine("---------------------Enter Employee Details are Shown below---------------------");
        Console.WriteLine("EmpNo is: " + employee.GetEmpNo());
        Console.WriteLine("EmpName is: " + employee.GetEmpName());
        Console.WriteLine("EmpSal is: " + employee.GetEmpSal());
        //--------------------------------------------------------------//
        Console.WriteLine("Address : " + address.GetHouseNo() + " " + address.GetHouseName() + " " + address.GetPinCode());
    }
}