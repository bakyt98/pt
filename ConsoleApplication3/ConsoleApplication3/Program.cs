using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            using (StreamReader number = new StreamReader(@"input.txt"))
            {
                string n;
                while ((n = number.ReadLine()) != null)
                {
                    if (n.GetType()==typeof(int))
                        numbers.Add(Convert.ToInt16(n));
                }
                foreach (int i in numbers) {
                    if (numbers[i] % 2 == 0) {
                        using (StreamWriter text = new StreamWriter(@"output.txt")) {

                            text.Write("{0} ",numbers[i]);

                        }
                    }

                }
            }

        }
    }
}
