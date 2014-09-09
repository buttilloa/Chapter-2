using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 25, length = 15;
            double price = 3.75;

            double cost = length* width*price;

            Console.Write("Arg The Price To Put Ye Ol' Shag Rag On Ye PoopDeck Be " + cost.ToString("C"));

        }
    }
}
