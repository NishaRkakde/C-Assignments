using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_Q3
{
    public delegate bool del(double amount);
    public delegate bool ZeroBalance();
    class Account
    {

        public event del MyEvent;
        public double acc_number;
        public string cust_number;
        public double acc_balance;
        public double amount;

        public Account(double no, string name, double bal)
        {
            acc_number = no;
            cust_number = name;
            acc_balance = bal;

            Display();
        }

        public void Deposit(double amount)
        {
            acc_balance = acc_balance + amount;
            Console.WriteLine("Deoposited amount: " + amount);
            Console.WriteLine("After Deposition, Balnce is: " + acc_balance);
        }

        public void Withdraw(double amount, del uBalance, ZeroBalance zBalance)
        {
            if (!zBalance())
            {
                if (!uBalance(amount))
                {
                    acc_balance = acc_balance - amount;
                    Console.WriteLine("Withdraw amount: " + amount);
                    Console.WriteLine("After Withdrawal, Balance is: " + acc_balance);
                }
            }

        }
        public void Display()
        {
            Console.WriteLine(" Customer Name is: " + cust_number + "\n Account Number is:"
                + acc_number + "\n Balance is: " + acc_balance);
        }
        public bool ZeroBalance()
        {
            if (acc_balance <= 0)
            {
                Console.WriteLine("Transaction cannot be continued...Balance is 0");
                return true;
            }
            else
                return false;
        }
        public bool UnderBalance(double amount)
        {
            if (acc_balance <= 500)
            {
                Console.WriteLine("Transaction cannot be continued below specified limit of Rs.- 500");
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
