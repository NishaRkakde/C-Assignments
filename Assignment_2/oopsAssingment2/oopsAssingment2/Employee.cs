using System;
using System.Collections.Generic;
using System.Text;

namespace oopsAssingment2
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

        public int EMPNO
        {
            get
            {
                return empno;
            }
            set
            {
                try
                {
                    if(value<0)
                    {
                        throw new Exception("Employee ID cannot be negative");
                    }
                    this.empno = value;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    Environment.Exit(1);
                }
            }
        }
        public string EMPNAME
        {
            get
            {
                return EmpName;
            }
            set
            {
                try
                {
                    if (String.IsNullOrEmpty(value))
                    {
                        throw new Exception("Employee name cannot be null.");
                    }
                    this.EmpName = value;
                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1);
                    Environment.Exit(1);
                }
           } }
        public double SALARY
        {
            get
            {
                return Salary;
            }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new Exception("Employee Salary cannot be negative");
                    }
                    this.Salary = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Environment.Exit(1);
                }
            }
        }

        
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

      //public void DisplayEmpDetails()
      //{  Console.WriteLine("The Emp Id is " + EMPNO + " The Emp Name is " + EMPNAME + "Employee Salary " + SALARY);}
        

    }
}

