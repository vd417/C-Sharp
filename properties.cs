using System;
using System.Collections.Generic;
using System.Text;

namespace Program_of_Has_A_using_Properties
{
    class Adress
    {
        private int houseNo;
        private string houseName;
        private int pinCode;

        public int HouseNo
        {
            set
            {
                houseNo = value;
            }
            get
            {
                return houseNo;
            }
        }
        public string HouseName
        {
            set
            {
                houseName = value;
            }
            get
            {
                return houseName;
            }
        }
        public int PinCode
        {
            set
            {
                pinCode = value;
            }
            get
            {
                return pinCode;
            }
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
        private Adress empAdress;

        public int EmpNo
        {
            set
            {
                empNo = value;
            }
            get
            {
                return empNo;
            }
        }
        public string EmpName
        {
            set
            {
                empName = value;
            }
            get
            {
                return empName;
            }
        }
        public double EmpSal
        {
            set
            {
                empSal = value;
            }
            get
            {
                return empSal;
            }
        }
        public Adress EmpAdress
        {
            set
            {
                empAdress = value;
            }
            get
            {
                return empAdress;
            }
        }
    }

    class Main_method
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
            Console.WriteLine("....................");

            Employee employee = new Employee();
            employee.EmpNo = num;

            employee.EmpName = Name;
            employee.EmpSal = Salery;
            Adress adress = new Adress();
            employee.EmpAdress = adress;
            adress.HouseNo = HouseNo;
            adress.HouseName = HouseName;
            adress.PinCode = PinCode;

            Console.WriteLine("No is: " + employee.EmpNo);
            Console.WriteLine("Name is: " + employee.EmpName);
            Console.WriteLine("Salery is: " + employee.EmpSal);
            Console.WriteLine("Adress is: " + employee.EmpAdress);

        }
    }

}
