using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Timer
{


    class Program
    {
        static void Main(string[] args)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 500;
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Enabled = true;

            //timer.Stop();

            Console.WriteLine("Press \'q\' to quit the sample.");
            while (true)
            {
                 
                if (Console.Read() == 's')
                {
                    timer.Stop();
                }
            }

        }
        public void Go(){

            Console.WriteLine("what?");
            
            Console.WriteLine("Hello World!");
            
            }
        public void OnTimedEvent(object source, ElapsedEventArgs e)
        {

            Go();
            
            
        }
    }
}