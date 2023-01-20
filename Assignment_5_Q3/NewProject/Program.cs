using System;
using System.Collections.Generic;

namespace NewProject
{
    class Employee
    {
        public int EmpId;
        public string EmpName;
         
        public Employee(int empid, string empname)
        {
            this.EmpId = empid;
            this.EmpName = empname;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Emplist = new List<Employee>();
            Emplist.Add(new Employee(1, "Nisha"));
            Emplist.Add(new Employee(2, "vijaya"));
            foreach (Employee e in Emplist)
            {
                Console.WriteLine(e.EmpId + " " + e.EmpName);
            }
            Console.WriteLine(Emplist.Count);
        }
    }
}
