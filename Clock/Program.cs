using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var clock = new Clock(12, 4, 37, "UTC+1", true);
            clock.DisplayTime();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
