using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    internal class Alarm
    {
        public int alarmHour;
        public int alarmMinute;
        public bool isAlarmOn;

        public Alarm(int hour, int minute) 
        {
            this.alarmHour = hour;
            this.alarmMinute = minute;
        }

        public void SetAlarm(int hour, int minute)
        {
            this.alarmHour = hour;
            this.alarmMinute = minute;
        }

        public void TurnOnAlarm() 
        {
            this.isAlarmOn = true; 
        }

        public void TurnOffAlarm()
        {
            this.isAlarmOn = false;
        }

        public bool IsAlarmTime(int hour, int minute)
        {
            if (this.alarmHour == hour && this.alarmMinute == minute) 
            { 
                return true; 
            } else 
            {
                return false; 
            }
        }
    }
}
