using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Timers;

namespace Snake
{
   
    

    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(20, 20, 5);
            board.start();
            System.Timers.Timer time = new System.Timers.Timer();
            Snake snake = new Snake(5);
            time.Interval = 1500;
            time.Elapsed += new ElapsedEventHandler(ChangeDir);
            time.Enabled = true;
            if (snake.canEat())
                time.Interval -= 100;
            if (Console.Read() == 's')
                time.Stop();

            //board.Time();
        }
        private static void ChangeDir(object sender, ElapsedEventArgs e) {
            Board board = new Board(20, 20, 5);
            board.Time();
        }
       

    }






    
}
