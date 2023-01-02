using System;
using System.Collections.Generic;
using System.Text;

namespace oopsAssigment3
{
    public class MarketingExecutive : Employee
    {
        private double kmTravel;
        private double tourA;
        private double telephoneA;
        private double marketingExecutiveGrossSalary;
        private double netSalary;
        public double KMTRAVEL 
        {  
            set { this.kmTravel = value; }
            get { return kmTravel; }
        }
        public double TELEPHONEA
        {
            set { telephoneA = 1000; }
            get { return telephoneA; }
        }
        public double TOURA
        {
            set { tourA = 5 * KMTRAVEL; }
            get { return tourA; }
        }
        public double MARKETINGEXECUTIVEGROSSSALARY
        {
            get { return marketingExecutiveGrossSalary; }
            set { marketingExecutiveGrossSalary = GROSSSALARY + TOURA + TELEPHONEA; }
        }
        public double calculateSalary()
        {
            netSalary = MARKETINGEXECUTIVEGROSSSALARY - (pF + Tds);
            return netSalary;
        }
        public MarketingExecutive(int empNo, string empName, double salary):base(empNo, empName, salary)
        {
            this.EMPNO = empNo;
            this.EMPNAME = empName;
            this.SALARY = salary;
            // this.KMTRAVEL = kmTravel;
            Console.WriteLine("Distance Travelled: ");
            this.KMTRAVEL = Convert.ToDouble(Console.ReadLine());
            this.GROSSSALARY = GROSSSALARY;
            this.TOURA = TOURA;
            this.TELEPHONEA = TELEPHONEA;
            this.pF = pF;
            this.Tds = Tds;
            this.MARKETINGEXECUTIVEGROSSSALARY = MARKETINGEXECUTIVEGROSSSALARY;
           
        }
        public void displayDetails()
        {
            Console.WriteLine("MARKETING EXECUTIVE DETAILS");
            
            Console.WriteLine("Employee No: "+ EMPNO);
            Console.WriteLine("Employee Name: " + EMPNAME);
            Console.WriteLine("Employee Salary: " + SALARY);
            //Console.WriteLine("Distance Travelled: " + KMTRAVEL);
            //this.KMTRAVEL = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Marketing Executive Gross Salary: " + MARKETINGEXECUTIVEGROSSSALARY);
            Console.WriteLine("Net Salary: " + netSalary);
        }
    }

}
