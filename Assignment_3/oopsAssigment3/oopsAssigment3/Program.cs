using System;

namespace oopsAssigment3
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
            Manager m = new Manager(273,"Vijji",5000);
            MarketingExecutive ME = new MarketingExecutive(11,"raha",5000);

            //emp.DisplayEmpDetails();
            emp.CalculateSalary();
            m.calculateSalary();
            m.displayDetails();
            ME.calculateSalary();
            ME.displayDetails();
            Console.ReadKey();
        }
    }
}
