using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    internal class Clock
    {
        // declare 
        public int hour;
        public int minute;
        public int second;
        public string timeZone;
        public bool is24HourFormat;

        public Clock(int hour, int minute, int second, string timeZone, bool is24HourFormat)
        {
            // const
            this.hour = hour;
            this.minute = minute;
            this.second = second;
            this.timeZone = timeZone;
            this.is24HourFormat = is24HourFormat;

        }
        public Clock()
        {
            // const default
            this.hour = 0;
            this.minute = 0;
            this.second = 0;
            this.timeZone = "UTC+2";
            this.is24HourFormat = true;

        }

        public void SetTime(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public void DisplayTime()
        {
            if (this.is24HourFormat)
            {
                Console.WriteLine($"{this.hour}:{this.minute}:{this.second}");
            }
        }

        public void SetTimeZone(string timeZone) 
        { 
            this.timeZone = timeZone; 
        }

        void ToggleTimeFormat()
        {
            if (this.is24HourFormat)
            {
                this.is24HourFormat = false;
            }else
            {
                this.is24HourFormat = true;
            }
        }

    }
}
