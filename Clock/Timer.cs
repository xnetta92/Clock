using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    internal class Timer
    {
        public int remainingSeconds;
        public Timer(int seconds) 
        {
            this.remainingSeconds = seconds;
        }

        public void SetTime(int seconds)
        { 
            remainingSeconds = seconds; 
        }

        public void StartTimer()
        {
            while (this.remainingSeconds > 0)
            {
                Console.WriteLine(this.remainingSeconds);
                this.remainingSeconds -= 1;
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
