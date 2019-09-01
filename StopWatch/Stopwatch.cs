using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class Stopwatch : OptionsMenu
    {
        private DateTime StartTime { get; set; }
        private DateTime StopTime { get; set; }
        private TimeSpan Duration => StopTime - StartTime;
        private bool isRunning = false;

        //public void Instructions()
        //{
        //    Console.WriteLine($"Please press the ENTER key to start your timer.\n" +
        //                      $"Use the SPACEBAR to pause or resume your timer. \n" +
        //                      $"Press the ESC key to exit. \n");
        //}

        public void Start()
        {
            if (isRunning == false)
            {
                StartTime = DateTime.Now;
                Console.WriteLine("The stopwatch has started!");
            }
            else
            {
                throw new System.InvalidOperationException("The stopwatch is already running, cannot start timer twice");
            }

            isRunning = true;
        }

        public void Stop()
        {
            Console.WriteLine("The stopwatch has stopped.");
            StopTime = DateTime.Now;
            isRunning = false;
            TimeElapsed();
        }

        public void Toggle()
        {

            if (isRunning == true)
            {
                //Console.WriteLine("Stopwatch has stopped");
                Stop();
            }
            else
            {
                //Console.WriteLine("Stopwatch has resumed");
                Start();
            }
        }

        public void TimeElapsed()
        {
            {
                Console.WriteLine($"Stopwatch was running for a total of: {Math.Round(Duration.TotalSeconds)} seconds.\n");
            }
        }
    }
}
