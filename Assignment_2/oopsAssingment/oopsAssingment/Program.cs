using System;

namespace oopsAssingment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(100, "Nisha",5000);
            //How to access the Methods outside the class
            emp.DisplayEmpDetails();
            emp.CalculateSalary();
            Console.ReadKey();

        }
    }
}
