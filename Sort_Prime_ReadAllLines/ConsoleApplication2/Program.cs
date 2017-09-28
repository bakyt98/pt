using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
           
                string[] number = System.IO.File.ReadAllLines(@"numbers.txt");

                int tmp;

                for (int j = 0; j < number.Length; j++)
                {
                    for (int i = 0; i < number.Length - 1; i++)
                    {
                        int n = Int16.Parse(number[i]);
                        int e = Int16.Parse(number[i + 1]);
                        if (n > e)
                        {
                            tmp = n;
                            number[i] = number[i + 1];
                            number[i + 1] = Convert.ToString(tmp);
                        }
                    }
                }

            int d=0;
                  for (int i = 0; i < number.Length; i++)
                  {
                      int c = 0;
                      d = Int16.Parse(number[i]);
                      for (int j = 1; j <= d; j++)
                      {
                          if (d % j == 0)
                              c++;
                      }
                      if (c == 2)
                      {
                       
                          break;
                      }

                  }

                using (System.IO.StreamWriter text =
                 new System.IO.StreamWriter(@"output.txt", true))
                 {
                     text.WriteLine("\nThe smallest prime number is " + d);
                 }   


                Console.ReadKey();
            }
        }
    }


