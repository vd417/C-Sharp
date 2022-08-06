namespace Object_Oriented_Program
{
    class Employee
    {
        private int empNo;
        private string empName;
        private double empSal;

        public void SetEmpNo(int eno)
        {
            eno = empNo;
        }

        public void SetEmpName(string eame)
        {
            eame = empName;
        }

        public void SetEmpSal(double esal)
        {
            esal = empSal
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
}