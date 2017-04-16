using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void Calculate();
    class Calc
    {
        public Calculate invoker;
        public void SumofNumber()
        {
            invoker.Invoke();
        }
    }
    class Sum
    {
        public Sum() { }
        public void Summa()
        {
            int s = 0;
            List<int> abs = new List<int>() { 492, 62, 86, 65, 752 };
            for (int i = 0; i < 5; i++)
            {
                s = s + abs[i];
            }
            Console.WriteLine(s);
            
        }
        class Program
    {
        static void Main(string[] args)
        {
            Sum s = new Sum();
            Calc sss = new Calc();
            sss.invoker = s.Summa;
                Thread.Sleep(10000);
            sss.SumofNumber();
            
            Console.ReadKey();
        }
    }
    


    }
    

}
