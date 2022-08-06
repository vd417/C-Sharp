using System;
using Object_Oriented_Program;

class EmployeeDetails
{
    static void Main()
    {
        Employee employee = new Employee;
        employee.SetEmpNo(101);
        employee.SetEmpName("Amit");
        employee.SetEmpSal(1015298.155);

        Console.WriteLine("Employee Number is : " + employee.GetEmpNo());
        Console.WriteLine("Employee Name is : " + employee.GetEmpName());
        Console.WriteLine("Employee Salary is : " + employee.GetEmpSal());
    }

}
