using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EMLEL_Models_Interface
{
    public delegate void Delegat(int seconds);
    public class Timer
    {
        public static void Test(int seconds)
        {
            Stopwatch interval = new Stopwatch();
            interval.Start();

            Console.WriteLine("\n You have 5 seconds to make a wish...");
            while (interval.ElapsedMilliseconds <= 5000)
            {
                if (interval.ElapsedMilliseconds == seconds * 1000)
                {
                    Console.WriteLine($"\n There are {5 - seconds} seconds left to make a wish...");
                    seconds += 2;
                    interval.Restart();
                }
            }
            Console.WriteLine("\n Time's up! Hope your wish will come true!");
        }

        public static void Pb07()
        {
            Delegat test = new Delegat(Test);
            test(2);
        }
    }
}
