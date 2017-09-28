using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max;
            List<int> numbers = new List<int>();
            System.IO.StreamReader file = new System.IO.StreamReader(@"numbers.txt");
            string line;
            while ((line = file.ReadLine()) != null)
            {
                
                numbers.Add(Convert.ToInt16(line));
            }

            file.Close();

            min = numbers[0];
            max = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {


                if (min > numbers[i]) min = numbers[i];
                if (max < numbers[i]) max = numbers[i];

            }
            using (System.IO.StreamWriter text =
            new System.IO.StreamWriter(@"output.txt", true))
            {
                text.WriteLine("Minimum number is " + min);
                text.WriteLine("Maximum number is " + max);
            }
            Console.ReadKey();
            
        }
    }
}
