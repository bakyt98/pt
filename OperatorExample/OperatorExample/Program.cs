using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExample
{
    class Point
    {
        int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "(" + this.x + ", " + this.y + ")";
        }

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.x + b.x, a.y + b.y);
        }
        public static Point operator -(Point a, Point b)
        {
            return new Point(a.x - b.x, a.y - b.y);
        }
        public static Point operator +(Point a, int value)
        {
            return new Point(a.x + value, a.y + value);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Point a = new Point(3, 4);
            Point b = new Point(5, 6);
            Point c = a + b;
            Console.WriteLine(c);
            Point d = a + 45;
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
