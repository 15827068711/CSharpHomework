using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Program
    {
        class Clock
        {
            public event EventHandler ring;

            public void Ringing()
            {
                EventHandler R = ring;
                if (R != null) R(this, EventArgs.Empty);
            }
            public void ClockRinging()
            {
                Console.WriteLine("Time!");
                Ringing();
            }
        }
        class SetClock
        {
            public SetClock(Clock c)
            {
                Console.WriteLine("Set the ringing time!");
                c.ring += timering;
            }
            void timering(object sender, EventArgs e)
            {
                Console.WriteLine("It's time to go!");
            }
            public void DelClock(Clock c)
            {
                c.ring -= timering;
            }
        }

        static void Main(string[] args)
        {
            Clock clock = new Clock();
            SetClock MyRing = new SetClock(clock);
            clock.ClockRinging();
        }
    }
}
