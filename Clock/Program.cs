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

            var alarm1 = new Alarm(13, 0);
            var alarm2 = new Alarm(14, 15);
            var alarm3 = new Alarm(14, 33);

            alarm1.TurnOnAlarm();
            alarm2.TurnOffAlarm();
            alarm3.SetAlarm(14, 30);

            Console.WriteLine(alarm1.IsAlarmTime(12, 58));
            Console.WriteLine(alarm1.IsAlarmTime(13, 0));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
