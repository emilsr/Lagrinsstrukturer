using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prov2array
{
    class Program
    {
        static void Main(string[] args)
        {
            //övning1 
            /*
            Console.WriteLine("Matta in 10 olika namn ");
            string[] myArray = { Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine() };
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.ReadKey();
            */

            //övning3 
            int[] myArray = { 12, 5, 6, 1, 2, 3, -2, -7, 0 };
            int tal;
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length-1; j++)
                {
                    if (myArray[j]<myArray[j+1])
                    {
                        tal = myArray[j + 1];
                        myArray[j + 1] = myArray[j];
                        myArray[j] = tal;
                    }
                }
            }
            for (int h = 0; h < myArray.Length; h++)
            {
                Console.WriteLine(myArray[h] + " ");
            }
            Console.ReadKey();
        }
    }
}
