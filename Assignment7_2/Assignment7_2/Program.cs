using System;
using System.IO;


namespace Assignment7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\NIKAKADE\source\repos\assignment7_2\Output.text";
            Console.WriteLine("Customer Details");
            Console.WriteLine("Enter Account Number: ");
            int Acc_Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer Name: ");
            string Customer_Name = Console.ReadLine();
            Console.WriteLine("Enter Balance: ");
            int Balance = Convert.ToInt32(Console.ReadLine());




            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write("Customer Name:" + Customer_Name + "\nAccount Number:" + Acc_Number + "\nBalance:" + Balance);
            }
            Console.WriteLine("Saved");



            Console.WriteLine("\n\n*******Reading Text File*******");



            using (StreamReader reader = new StreamReader(file))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}