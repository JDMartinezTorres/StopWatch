using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class OptionsMenu 
    {
        public void Instructions()
        {
            //Console.Clear();
            Console.WriteLine($"Please press the ENTER key to start your timer.\n" +
                              $"Use the SPACEBAR to pause or resume your timer. \n" +
                              $"Press the ESC key to exit. \n");
            SelectionSwitch();
        }

        public void SelectionSwitch()
        {
            bool timerShouldStop = false;
            var stopwatch = new Stopwatch();

            while (timerShouldStop != true)
            {
                ConsoleKeyInfo currentKey = Console.ReadKey(true);
                switch (currentKey.Key)
                {
                    case ConsoleKey.Enter:
                        try
                        {
                            stopwatch.Start();
                        }
                        catch (Exception alreadyRunning)
                        {
                            Console.WriteLine(alreadyRunning.Message);
                        }
                        break;
                    case ConsoleKey.Spacebar:
                        stopwatch.Toggle();
                        break;
                    case ConsoleKey.Backspace:
                        stopwatch.Stop();
                        timerShouldStop = true;
                        break;
                    case ConsoleKey.Escape:
                        stopwatch.Stop();
                        timerShouldStop = true;
                        break;
                }
                
            }
            Console.ReadKey();
        }
    }
}
