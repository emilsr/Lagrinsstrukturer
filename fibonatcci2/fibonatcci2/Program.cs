//Wilhelm Åsander och Emil Stener 27 Januari 2017
//Programmet räknar ut och skriver sedan ut de 50 första talen i fibonacci serien
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonatcci2
{
    class Program
    {
        static void Main(string[] args)
        {
            {   
                long num1 = 0;
                long num2 = 1;
                long sum = 1;
                int i = 1;
                Console.WriteLine("F0: " + num1);
                while (i < 51)
                {
                    Console.WriteLine("F"+ i +": "+ num2);
                    sum = num1 + num2;
                    num1 = num2;
                    num2 = sum;
                    i++;
                }
            }
            Console.ReadKey();
        }
    }
}
