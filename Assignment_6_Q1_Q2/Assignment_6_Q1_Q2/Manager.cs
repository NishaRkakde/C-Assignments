using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_Q1_Q2
{
    public delegate void ManagerInfo();
    class Manager : Employee, IPrintable
    {
        int empId;
        string empName;

        double empSal;
        double petrol_a, food_a, other_a, gs, pf, tds, netsal;
        public Manager(int empId, string empName, double empSal) : base(empId, empName, empSal)
        {
            this.empId = empId;
            this.empName = empName;
            this.empSal = empSal;
        }
        public override void CalGrossSal()
        {
            base.CalGrossSal();


            petrol_a = (this.empSal * 8) / 100;
            food_a = (this.empSal * 13) / 100;
            other_a = (this.empSal * 3) / 100;
            gs = petrol_a + food_a + other_a + this.grossSal;

        }

        public override void CalculateSal()
        {
            pf = this.pf + gs / 10;

            tds = this.tds + gs / 18;

            netsal = gs - (pf + tds);
        }

        public void info()
        {
            Console.WriteLine("Manager  Salary= {0} ", empSal);
            Console.WriteLine("Manager  Gross Salary= {0} ", gs);
            Console.WriteLine("Manager  netSal= {0} ", netsal);
        }
    }
}
