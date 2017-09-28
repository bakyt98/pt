using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string nurbek = "nurbek";
            string dyussenbek = "dyussenbek";
            Console.WriteLine("Name: {0} Again Name: {0} Surname: {1}", nurbek, dyussenbek);
            Console.ReadKey();
            string text = File.ReadAllText(@"C:\Users\user\Desktop\sum.txt");
            string[] numbers = text.Split(' ');
            int a = Convert.ToInt32(numbers[0]);
            int b = Convert.ToInt32(numbers[1]);
            StreamWriter fileWriter = new StreamWriter(@"C:\Users\user\Desktop\ans.txt", true);
            fileWriter.WriteLine(a + b);
            fileWriter.Close();
            Console.ReadKey();
        }
    }
}
