using System;

namespace oops3rdAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee ID");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter employee salary");
            double salary = Convert.ToDouble(Console.ReadLine());
            Employee emp = new Employee(id, name, salary);

            //How to access the Methods outside the class
            //emp.DisplayEmpDetails();
            emp.CalculateSalary();
            Console.ReadKey();
        }
    }
}
