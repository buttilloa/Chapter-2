using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChickenPearls
{
    class Program
    {
        static void Main(string[] args)
        {
            int Francis = 37, Ulyss = 38, Chicken3 = 50, Kristoff = 23;
            int total = Francis + Ulyss + Chicken3 + Kristoff;
            int Dosens = total / 12;
            int Dosens2 = total % 12;
            Console.Write("Ye ol Chickends layed "+Dosens +" Dozen end " + Dosens2+ " Chicken Pearls");
        }
    }
}
