using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = 197;
            double time = minutes / 60;
            double time2 =minutes % 60 ;
            
            Console.Write("Arg Ye wasted time is "+ time+ ":"+time2);

        }
    }
}
