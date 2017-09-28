using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_args
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) {
                args[i] = Console.ReadLine();
            }
            bool b = false;
            for (int i = 0; i < 5; i++) {
                for (int j = 2; j < Int32.Parse(args[i]); j++) {
                    if (Int32.Parse(args[i]) % j != 0)
                    {
                        b = true;
                    }
                    else {
                        b = false;
                        break;
                    }
                 }
                if (b) Console.WriteLine(Int32.Parse(args[i]));

            }
        }

    }
    
}
