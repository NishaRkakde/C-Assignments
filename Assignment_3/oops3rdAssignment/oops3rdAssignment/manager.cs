using System;
using System.Collections.Generic;
using System.Text;

namespace oops3rdAssignment
{
    public class Manager : Employee
    {
        private double petrolAllowance;
        private double foodAllowance;
        private double otherAllowance;
        private double managerGrossSalary;
        private double netSalary;
        public double PETROLALLOWANCE
        {
            get { return petrolAllowance; }
            set { petrolAllowance = (SALARY * 8) / 100; }
        }
        public double FOODALLOWANCE
        {
            get { return foodAllowance; }
            set { foodAllowance = (SALARY * 13) / 100; }
        }
        public double OTHERALLOWANCE
        {
            get { return otherAllowance; }
            set { otherAllowance = (SALARY * 3) / 100; }
        }



        public double MANAGERGROSSSALARY
        {
            set
            {
                managerGrossSalary = GROSSSALARY + PETROLALLOWANCE + FOODALLOWANCE + OTHERALLOWANCE;
            }
            get { return managerGrossSalary; }
        }
        public Manager(int empNo, string empName, double salary)
        {
            this.EMPNO = empNo;
            this.EMPNAME = empName;
            this.SALARY = salary;
            this.GROSSSALARY = GROSSSALARY;
            this.PF = PF;
            this.TDS = TDS;
            this.PETROLALLOWANCE = PETROLALLOWANCE;
            this.FOODALLOWANCE = FOODALLOWANCE;
            this.OTHERALLOWANCE = OTHERALLOWANCE;
            this.MANAGERGROSSSALARY = MANAGERGROSSSALARY;
        }
        public double calculateSalary()
        {
            netSalary = MANAGERGROSSSALARY - (PF + TDS);
            return netSalary;
        }



        public new void DisplayEmpDetails()
        {
            Console.WriteLine("------PRINTING MANAGER DETAILS------");
            Console.WriteLine($"Employee No: {EMPNO}");
            Console.WriteLine($"Employee Name: {EMPNAME}");
            Console.WriteLine($"Employee Salary: Rs.{SALARY}");
            Console.WriteLine($"Manager Gross Salary: Rs.{MANAGERGROSSSALARY}");
            Console.WriteLine($"Net Salary: Rs.{netSalary}");
        }
    }
}
    

