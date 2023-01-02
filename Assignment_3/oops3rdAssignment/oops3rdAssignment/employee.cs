using System;
using System.Collections.Generic;
using System.Text;

namespace oops3rdAssignment
{
    public class Employee
    {
        private int empno;
        private string EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double TDS;
        private double PF;
        private double NetSalary;
        private double GrossSalary;

        public int EMPNO { get; set; }
        public string EMPNAME { get; set; }
        public double SALARY { get; set; }
        public Employee(int empno, string ename, double sal)
        {
            this.EMPNO = empno;
            this.EMPNAME = ename;
            this.SALARY = sal;
            this.GROSSSALARY = GrossSalary;
        }
        public double GROSSSALARY
        {
            set
            {
                if (SALARY < 5000)
                {
                    HRA = (SALARY * 10) / 100;
                    TA = (SALARY * 5) / 100;
                    DA = (SALARY * 15) / 100;
                    GrossSalary = SALARY + HRA + TA + DA;
                }
                else if (SALARY < 10000)
                {
                    HRA = (SALARY * 10) / 100;
                    TA = (SALARY * 5) / 100;
                    DA = (SALARY * 15) / 100;
                    GrossSalary = SALARY + HRA + TA + DA;
                }
                else if (SALARY < 15000)
                {
                    HRA = (SALARY * 10) / 100;
                    TA = (SALARY * 5) / 100;
                    DA = (SALARY * 15) / 100;
                    GrossSalary = SALARY + HRA + TA + DA;
                }
                else if (SALARY < 20000)
                {
                    HRA = (SALARY * 10) / 100;
                    TA = (SALARY * 5) / 100;
                    DA = (SALARY * 15) / 100;
                    GrossSalary = SALARY + HRA + TA + DA;
                }
                else if (SALARY >= 20000)
                {
                    HRA = (SALARY * 10) / 100;
                    TA = (SALARY * 5) / 100;
                    DA = (SALARY * 15) / 100;
                    GrossSalary = SALARY + HRA + TA + DA;
                }
            }
            get
            {
                return GrossSalary;
            }
        }
        public void CalculateSalary()
        {
            Console.WriteLine("GrossSalary : " + GROSSSALARY);
            PF = (GROSSSALARY * 10) / 100;
            TDS = (GROSSSALARY * 18) / 100;
            NetSalary = GROSSSALARY - (PF + TDS);
            Console.WriteLine("NetSalary : " + NetSalary);
        }

        public void DisplayEmpDetails()
        {
            Console.WriteLine("The Emp Id is " + EMPNO + " The Emp Name is " + EMPNAME + "Employee Salary " + SALARY);
        }

    }
}
