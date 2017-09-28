using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Snake
{
    class Board
    {
        Snake snake;
        Food food;
        int w, h;
        public Board(int w, int h, int snake_length)
        {
            this.w = w;
            this.h = h;
            this.snake = new Snake(snake_length);
            this.food = new Food(snake_length);
        }
        void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(x, y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }



        void print()
        {


            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    WriteAt("-", i, 0);
                    WriteAt("|", 0, j);
                    WriteAt("|", w - 1, j);
                    WriteAt("-", i, h - 1);
                }
            }


        }

        public void Time() {
            
            snake.print();
            snake.go();
            if (snake.canEat())
            {

                snake.print();
                food.food();

            }
               // snake.level();
            ConsoleKeyInfo pressed = Console.ReadKey();
            if (pressed.Key == ConsoleKey.RightArrow)
                snake.right();
            else if (pressed.Key == ConsoleKey.LeftArrow)
                snake.left();
            else if (pressed.Key == ConsoleKey.UpArrow)
                snake.up();
            else if (pressed.Key == ConsoleKey.DownArrow)
                snake.down();
        
    }
        public void start()
        {
            print();
            food.food();


           

            //snake.print();
           
           /* while (true)
            {
                snake.print();
                snake.canEat();
                snake.go();
                if (snake.canEat())
                {
                    
                    snake.print();
                    food.food();
                    
                }
                ConsoleKeyInfo pressed = Console.ReadKey();
                if (pressed.Key == ConsoleKey.RightArrow)
                    snake.right();
                else if (pressed.Key == ConsoleKey.LeftArrow)
                    snake.left();
                else if (pressed.Key == ConsoleKey.UpArrow)
                    snake.up();
                else if (pressed.Key == ConsoleKey.DownArrow)
                    snake.down();



            }*/

        }

    /*    private void Elap(object sender, ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }*/
    }
    }


