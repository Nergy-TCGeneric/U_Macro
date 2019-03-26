using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMacro
{
    public class Delay
    {
        public TimeSpan delayTimeSpan;

        public Delay(TimeSpan newDelay)
        {
            this.delayTimeSpan = newDelay;
        }

        public Delay(int msec)
        {
            this.delayTimeSpan = new TimeSpan(0, 0, 0, 0, msec);
        }

        public override string ToString()
        {
            return String.Format("(지연) {0} 밀리초", delayTimeSpan.TotalMilliseconds);
        }
    }
}
