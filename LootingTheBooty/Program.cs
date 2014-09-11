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
            Console.Write("Enter ye beard size and color: ");
            Name = Console.ReadLine();
            Console.Write("Secret Ship Number: ");
            SSN = Console.ReadLine();
            Console.Write("Hourly Pillage Rate: ");
            pay = Console.ReadLine();
            Console.Write("Hours Spent Sailing the Open Seas: ");
            Hours = Console.ReadLine();
            
            gross = Convert.ToDouble(pay) * Convert.ToDouble(Hours);
            Double Payint = Convert.ToDouble(pay);
            Console.WriteLine("");
            
            Console.WriteLine("Voyage Summary for: " + Name);
            Console.WriteLine("SSN: " + SSN);
            Console.WriteLine("Ye don looted all the booty "+ gross.ToString("C")+ " at "+ Payint.ToString("C")+" Per Hour") ;
            
            Console.WriteLine("");
            Double Tax = .15, Tax2 = .05;
            Console.WriteLine("Ye Gross Loot:                   " + gross.ToString("C"));
            Console.WriteLine("Federal loot withholding:        " + (gross * Tax).ToString("C"));
            Console.WriteLine("Island withholding :             " + (gross * Tax2).ToString("C"));
            double FedTax = gross*Tax,Statetax=gross*Tax2;

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("After Ye Get Pillaged By The Government, Yargh: " + ((gross - FedTax) - Statetax).ToString("C"));


        }
    }
}
