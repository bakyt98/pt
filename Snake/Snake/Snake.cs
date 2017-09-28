using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Snake
{
    //0-up
    //1-down
    //2-left
    //3-righ
    class Snake
    {
        public int direction;
        public List<int> X;
        public List<int> Y;
        public int length;
        public Snake(int length)
        {
            this.length = length;
            X = new List<int>();
            Y = new List<int>();
            direction = 3;


            

          //  if (Deserialize() == null)
            // {
            for (int i = 1; i <= length; i++)
            {
                X.Add(i);
                Y.Add(1);
            }
          /*  }
           else {


             foreach (Position i in Deserialize()) {
               X.Add(i.a);
               Y.Add(i.b);
               }
             }*/

        }

        /* public void level() {
             if ((length - 5) == 3) {
                 for (int i = 1; i < length; i++)
                 {
                     Console.SetCursorPosition(i, 5);
                     Console.Write("/");
                     using (StreamWriter level = new StreamWriter(@"level.txt")) {
                         level.WriteLine(i);
                     }
                 }

             }
         }*/
        public void go() {
            if (direction == 0) {
                for (int i = 0; i < length - 1; i++)
                {

                    X[i] = X[i + 1];
                    Y[i] = Y[i + 1];
                }
                Y[length - 1]--;
            }
            if (direction == 3) {
                for (int i = 0; i < length - 1; i++)
                {

                    X[i] = X[i + 1];
                    Y[i] = Y[i + 1];
                }

                X[length - 1]++;

            }
            if (direction == 2) {
                for (int i = 0; i < length - 1; i++)
                {

                    X[i] = X[i + 1];
                    Y[i] = Y[i + 1];
                }
                X[length - 1]--;
            }
            if (direction == 1) {
                for (int i = 0; i < length - 1; i++)
                {

                    X[i] = X[i + 1];
                    Y[i] = Y[i + 1];
                }
                Y[length - 1]++;

            }
        }
        public void right()
        {
            if (X[length - 1] == 18)
                return;

            if (direction == 2)
                return;
            direction = 3;
            for (int i = 0; i < length - 1; i++)
            {
                if (X[length - 1] + 1 == X[i] && Y[length - 1] == Y[i])
                    return;
            }
               /* for (int i = 0; i < length - 1; i++)
            {
               
                X[i] = X[i + 1];
                Y[i] = Y[i + 1];
            }

            X[length - 1]++;*/
        }
        public void left()
        {
            if (X[length - 1] == 1)
                return;
            if (direction == 3)
                return;
            direction = 2;
            for (int i = 0; i < length - 1; i++)
            {
                if (X[length - 1] - 1 == X[i] && Y[length - 1] == Y[i])
                    return;
            }
               /* for (int i = 0; i < length - 1; i++)
            {
               
                X[i] = X[i + 1];
                Y[i] = Y[i + 1];
            }
            X[length - 1]--;*/
        }
        public void up()
        {
            if (Y[length - 1] == 1)
                return;
            if (direction == 1)
                return;
            direction = 0;
            for (int i = 0; i < length - 1; i++)
            {
                if (Y[length - 1] - 1 == Y[i] && X[length - 1] == X[i])
                    return;
            }
               /* for (int i = 0; i < length - 1; i++)
            {
                
                X[i] = X[i + 1];
                Y[i] = Y[i + 1];
            }
            Y[length - 1]--;*/
        }
        public void down()
        {
            if (Y[length - 1] == 18)
                return;
            if (direction == 0)
                return;
            direction = 1;
            for (int i = 0; i < length - 1; i++)
            {
                if (Y[length - 1] + 1 == Y[i] && X[length - 1] == X[i])
                    return;
            }
                /*for (int i = 0; i < length - 1; i++)
            {
               
                X[i] = X[i + 1];
                Y[i] = Y[i + 1];
            }
            Y[length - 1]++;*/
        }
        public bool canEat()
        {
            List<int> posfood = new List<int>();

            using (StreamReader pos = new StreamReader(@"posfood.txt"))
            {
                string line;

                while ((line = pos.ReadLine()) != null)
                {
                    posfood.Add(Int16.Parse(line));
                }
            }
            int posf1, posf2;

            posf1 = posfood[0];
            posf2 = posfood[1];
            for (int i = 0; i < length; i++)
            {
                if (X[i] == posf1 && Y[i] == posf2)
                {


                    if (direction == 0)
                    {
                        Y.Add(Y[length - 1] - 1);
                        X.Add(X[length - 1]);
                    }
                    if (direction == 1)
                    {
                        Y.Add(Y[length - 1] + 1);
                        X.Add(X[length - 1]);
                    }
                    if (direction == 2)
                    {
                        Y.Add(Y[length - 1]);
                        X.Add(X[length - 1] - 1);
                    }
                    if (direction == 3)
                    {
                        Y.Add(Y[length - 1]);
                        X.Add(X[length - 1] + 1);
                    }

                    length++;
                    Console.SetCursorPosition(21, 1);
                    Console.Write(length - 5);
                    return true;

                }
            }
            return false;
        }

        public void clear()
        {
            List<int> posfood = new List<int>();
            using (System.IO.StreamReader pos = new System.IO.StreamReader(@"posfood.txt"))
            {
                string line;

                while ((line = pos.ReadLine()) != null)
                {
                    posfood.Add(Int16.Parse(line));
                }
            }
            int posf1, posf2;
            posf1 = posfood[0];
            posf2 = posfood[1];

            for (int i = 1; i < 19; i++)
            {
                for (int j = 1; j < 19; j++)
                {
                    if (i == posf1 && j == posf2)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write("*");

                    }

                    else
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write(" ");
                    }

                }
            }

        }
        public void print()
        {

            clear();
            
            List<Position> x = new List<Position>();
            for (int i = 0; i < length; i++)
            {

                //X[i] = (X[i] + w) % w;
                //Y[i] = (Y[i] + h) % h;
                Console.SetCursorPosition(X[i], Y[i]);

                x.Add(new Position(X[i], Y[i]));

                if (i == X.Count-1)
                    Console.Write("O");
                else
                    Console.Write("X");
            }
            Serialize(x);
        }
        static void Serialize(List<Position> x)
        {

            BinaryFormatter s = new BinaryFormatter();
            FileStream bin = new FileStream(@"binpossnake.data", FileMode.Create);

            s.Serialize(bin, x);

            bin.Close();
        }
        static List<Position> Deserialize()
        {
            BinaryFormatter ds = new BinaryFormatter();
            FileStream text = new FileStream(@"binpossnake.data", FileMode.OpenOrCreate);
            List<Position> binData = (List<Position>)ds.Deserialize(text);
            text.Close();
            return binData;
        }
        public List<int> getX()
        {
            return X;
        }
        public List<int> getY()
        {
            return Y;
        }

    }
}
