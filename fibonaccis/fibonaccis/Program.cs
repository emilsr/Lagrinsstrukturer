using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonaccis
{
    class Program
    {
        public static long Fibonacci(int n)
        {
            long a = 0;
            long b = 1;
            

            for (int i = 0; i < n; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main()
        {
            for (int i = 0; i < 51; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
            Console.ReadKey();
        }
        
    }
}



