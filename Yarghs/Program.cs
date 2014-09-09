using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yarghs
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 42, length = 25;
            double price = 3.75;

            double cost = length * width * price;

            Console.Write("Arg The Price To Put Ye Ol' Love Rug On Ye Hull of Ye Vessel Be " + cost.ToString("C"));
        }
    }
}
