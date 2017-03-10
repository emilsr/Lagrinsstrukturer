using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fel_hantering
{
    class Program
    {
        static void Main(string[] args)
        {   //övning1
            Console.Write("Ange din inkomst: ");
            int inkomst = 0;
            int timmar = 0;
            try
            {
                 inkomst = int.Parse(Console.ReadLine());
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);               
            }
          
            Console.Write("Ange antal timmar: ");
            try
            {
                 timmar = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Din timlön blev: " + (inkomst / timmar) + " kr/h");

            Console.ReadKey();
            //övning2
            //programes kommmer krasa om timmar=0 eftersom du inte kan della med 0
            
            //övning3
        }
    }
}
