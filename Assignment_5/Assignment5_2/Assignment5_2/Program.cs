using System;
using System.Collections;

namespace Assignment5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Employees you want to store:");
            int size = Convert.ToInt32(Console.ReadLine());
            ArrayList employeeList = new ArrayList();
            Console.WriteLine("Enter employee data");
            for(int i=0;i<size;i++)
            {
                Console.WriteLine("Enter ID");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter salary");
                double sal = Convert.ToDouble(Console.ReadLine());
                //create employee object
                employeeList.Add(new Employee(id, name, sal));

            }
            Console.WriteLine("Displaying employee list");
            foreach(Object o in employeeList)
            {
                Console.WriteLine(o + "\n");
            }
        }
    }
}
