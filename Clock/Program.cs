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

            // 1.,
            var myClock = new Clock(12, 31, 45, "UTC+2", true);

            // 2.,
            
            /*
            var alarms = new List<Alarm>();
            alarms.Add(new Alarm(6, 0));
            alarms.Add(new Alarm(8, 0));
            */

            List<Alarm> alarms = new List<Alarm>
            {
                new Alarm(6, 0),
                new Alarm(8, 0)
            };
      
            // 3.,
            var timer1 = new Timer(10);

            // 4.,
            myClock.DisplayTime();

            //myClock.ToggleTimeFormat(); // De ha public az Is24HourFormat miert nem jo?
            //myClock.DisplayTime();
            
            /* 12H clock test 
            var myClock2 = new Clock(17, 34, 16, "UTC+2", false);
            myClock2.DisplayTime();
            */

            // 5.,
            foreach (var alarm in alarms)
            {
                if (alarm.IsAlarmTime(myClock.GetCurrentHour(), myClock.GetCurrentMinute()))
                {
                    Console.WriteLine("Az ébresztő megszólalt!");
                }
            }

            // 6.,
            timer1.StartTimer();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
