using System;
using System.Collections.Generic;
using System.Text;

namespace oops3rdAssignment
{
    class marketingExcecutive : Employee
    {
        double KmTravel;
        double tourA;
        double TelA;
        double gs;

        public new void Calculate_Gross()
        {
            Console.WriteLine("Enter travel distance in KM: ");
            KmTravel = Convert.ToInt32(Console.ReadLine());
            TelA = 1000;
            tourA = KmTravel * 5;
            base.Calculate_Gross();
            gs = GROSSSALARY;
            GROSSSALARY = GROSSSALARY + TelA + tourA;

        }
        public override void CalculateSalary()
        {
            PF = gs / 10;
            TDS = gs / 18;
            NetSalary = gs - (PF + TDS);
        }
        public new void display()
        {
            Console.WriteLine("Employee no :");
            Console.WriteLine("Employee Name : ");
            Console.WriteLine("Employee Salary :");
           // Console.WriteLine("")
            Console.WriteLine("Petrol allowance :");
            Console.WriteLine("Food allowance : ");
            Console.WriteLine("Other allowance: ");
            Console.WriteLine("HRA :");
            Console.WriteLine("TA :");
            Console.WriteLine("TDS : ");
            Console.WriteLine("DA: ");
            Console.WriteLine("Gross Salary: ");
            Console.WriteLine("PF: ");
            Console.WriteLine("Net Salary: ");
        }
    }
}
