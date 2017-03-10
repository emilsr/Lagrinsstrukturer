using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonatcci
{
    // Wille och Emil 01/27-17
    class Program
    {
        // tänk på att du måste andvända "long" istället för "int" efter som "int" bara 32 bitar,  
        public static long Fibonacci(int position)
        {
            long a = 0; //initiera "long" variabel 
            long b = 1; 
            for (int i = 0; i < position; i++) //räknar ut Fibonacci (förklara)
            {
                long temp = a;
                a = b;
                b = temp + b;
            }
            return a; //skickar värdet på "Fibonacci" till "Main" 
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

