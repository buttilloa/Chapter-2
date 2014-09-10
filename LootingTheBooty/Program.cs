using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LootingTheBooty
{
    class Program
    {
       
        static void Main(string[] args)
        {
            String Name, SSN, pay, Hours;
            double gross;
            Console.Write("Enter your name: ");
            Name = Console.ReadLine();
            Console.Write("Social Security Number: ");
            SSN = Console.ReadLine();
            Console.Write("Hourly Pay Rate: ");
            pay = Console.ReadLine();
            Console.Write("Hours Worked: ");
            Hours = Console.ReadLine();
            
            gross = Convert.ToDouble(pay) * Convert.ToDouble(Hours);
            Double Payint = Convert.ToDouble(pay);
            Console.WriteLine("");
            
            Console.WriteLine("Payroll Summary for: " + Name);
            Console.WriteLine("SSN: " + SSN);
            Console.WriteLine("You earned "+ gross.ToString("C")+ " at "+ Payint.ToString("C")+" Per Hour") ;
            
            Console.WriteLine("");
            Double Tax = .15, Tax2 = .05;
            Console.WriteLine("Gross Pay:                  "+ gross);


        }
    }
}
