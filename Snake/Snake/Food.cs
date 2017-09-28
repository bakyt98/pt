using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food
    {
        Random fx;
        Random fy;
        Snake snake;

        public Food(int snake_length)
        {
            fx = new Random();
            fy = new Random();
            snake = new Snake(snake_length);
            
        }
        public void food()
        {
            int a = 0;
            int b = 0;
            bool snakepos = false;
          
            List<int> posX = snake.getX();
            List<int> posY = snake.getY();
            for (int i = 1; i < 19; i++)
            {
                for (int j = 1; j < 19; j++)
                {
                  // if (Deserialization() == null)
                    //{
                        if (i == fx.Next(1, 18) && j == fy.Next(1, 18))
                        {
                            for (int it = 0; it < posX.Count; it++)
                            {
                                if ((i == posX[it]) && (j == posY[it]))
                                {
                                    snakepos = true;


                                    break;
                                }
                            }
                            if (snakepos == false)
                            {
                                Console.SetCursorPosition(i, j);
                                List<Position> x = new List<Position>();
                                x.Add(new Position(a, b));
                                Serialization(x);
                                Console.Write("*");
                                a = i;
                                b = j;
                            }
                            
                        }

                  /*  }
                    else {
                        foreach (Position q in Deserialization())
                        {
                            a = q.a;
                            b = q.b;
                            Console.SetCursorPosition(q.a, q.b);
                            Console.Write("*");
                        }
                    }*/
                }
            }

            using (System.IO.StreamWriter position = new System.IO.StreamWriter(@"posfood.txt"))
            {
                
                    position.WriteLine(a);
                    position.WriteLine(b);
               
            }

        }
        static void Serialization(List<Position> x)
        {

            BinaryFormatter s = new BinaryFormatter();
            FileStream bin = new FileStream(@"binposfood.data", FileMode.Create);

            s.Serialize(bin, x);

            bin.Close();
        }
        /* static List<Position> Deserialization()
         {
             BinaryFormatter ds = new BinaryFormatter();
             FileStream text = new FileStream(@"binposfood.data", FileMode.OpenOrCreate);
             List<Position> binData = (List<Position>)ds.Deserialize(text);
             text.Close();
            return binData;
         }*/
    }
}
