class Address
{
    private int houseNo;
    private string houseName;
    private int pincode;
    public void SetHouseNo(int houseNo)
    {
        this.houseNo = houseNo;
    }
    public void SetHouseName(string houseName)
    {
        this.houseName = houseName;
    }
    public void Setpincode(int pincode)
    {
        this.pincode = pincode;

    }
    public int GethouseNo()
    {
        return this.houseNo;
    }
    public string GethouseName()
    {
        return this.houseName;
    }
    public int Getpincode()
    {
        return this.pincode;
    }
    public override string ToString()
    {
        return houseNo + " " + houseName + " " + pincode; 
    }
}

class Employee
{
    private int empNo;
    private string empName;
    private double empSal;
    private Address empAddress;

    public void SetEmpNo(int empNo)
    {
        this.empNo = empNo;
    }
    public void SetEmpName(string empName)
    {
        this.empName = empName;
    }
    public void SetEmpSal(double empSal)
    {
        this.empSal = empSal;
    }
    public void SetEmpAddress(Address empAddress)
    {
        this.empAddress = empAddress;
    }
    public int GetEmpNo()
    {
        return this.empNo;
    }
    public string GetEmpName()
    {
        return this.empName;
    }
    public double GetEmpSal()
    {
        return this.empSal;
    }
   
   
}

class Information { 
    static void Main()
    {
        Employee employee = new Employee();
        employee.SetEmpNo(101);
        employee.SetEmpName("Amit Sharma");
        employee.SetEmpSal(25000.99);
        Address address = new Address();
        address.SetHouseNo(999);
        address.SetHouseName("Kusum Vila");
        address.Setpincode(123456);
        employee.SetEmpAddress(address);
        System.Console.WriteLine("------------");
        System.Console.WriteLine("Employee Information");
        System.Console.WriteLine("------------");
        System.Console.WriteLine("No is: " + employee.GetEmpNo());
        System.Console.WriteLine("Name is:" + employee.GetEmpName());
        System.Console.WriteLine("Sal is: " + employee.GetEmpSal());
        System.Console.WriteLine("HouseNo is: " + address.GethouseNo());
        System.Console.WriteLine("HouseName is: " + address.GethouseName());
        System.Console.WriteLine("HousePinCode is: " + address.Getpincode());
    }
}
