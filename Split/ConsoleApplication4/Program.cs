using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "3+2+234-3";
            string[] numd = s.Split('+', '-');
            string[] ops = s.Split('3', '2', '4');

            foreach (string a in numd) {
                Console.WriteLine(a);
            }
            foreach (string a in ops)
            {
                Console.WriteLine(a);
            }
            
            Console.ReadKey();
        }
    }
}
