using System;
using System.Collections.Generic;
using System.Text;


namespace oopsAssigment3
{
    public class Manager : Employee
    {
        private double petrolA;
        private double foodA;
        private double otherA;
        private double managerGrossSalary;
        private double netSalary;

        public double PETROLALLOWANCE
        {
           
            set { petrolA = (SALARY * 8) / 100; }
            get { return petrolA; }
        }
        public double FOODALLOWANCE
        {
           
            set { foodA = (SALARY * 13) / 100; }
            get { return foodA; }
        }
        public double OTHERALLOWANCE
        {
            set { otherA = (SALARY * 3) / 100; }
            get { return otherA; }
        }

        public double MANAGERGROSSSALARY
        {
            set
            {
                managerGrossSalary = GROSSSALARY + PETROLALLOWANCE + FOODALLOWANCE + OTHERALLOWANCE;
            }
            get { return managerGrossSalary; }
        }
        public Manager(int empNo, string empName, double salary):base(empNo, empName, salary)
        {
            this.EMPNO = empNo;
            this.EMPNAME = empName;
            this.SALARY = salary;
            this.GROSSSALARY = GROSSSALARY;
            this.pF = pF;
            this.Tds = Tds;
            this.PETROLALLOWANCE = PETROLALLOWANCE;
            this.FOODALLOWANCE = FOODALLOWANCE;
            this.OTHERALLOWANCE = OTHERALLOWANCE;
            this.MANAGERGROSSSALARY = MANAGERGROSSSALARY;
        }
        public double calculateSalary()
        {
            netSalary = MANAGERGROSSSALARY - (pF + Tds);
            return netSalary;
        }

        public new void displayDetails()
        {
            Console.WriteLine("MANAGER DETAILS");
            Console.WriteLine("Employee No: " + EMPNO);
            Console.WriteLine("Employee Name:" +EMPNAME);
            Console.WriteLine("Employee Salary : " +SALARY);
            Console.WriteLine("Manager Gross Salary: " +MANAGERGROSSSALARY);
            Console.WriteLine("Net Salary: " +netSalary);
        }
    }
}
    

   
 
