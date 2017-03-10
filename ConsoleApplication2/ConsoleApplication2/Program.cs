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
           
            double inkomst = 0;
            double timmar = 0;
            Console.Write("Ange din inkomst: ");
            inkomst = double.Parse(Console.ReadLine());
            Console.Write("Ange timmar: ");
            timmar = double.Parse(Console.ReadLine());
            Console.WriteLine("Din timlön blev: " + (inkomst / timmar) + " kr/h");
            Console.ReadKey();
            //övning2
            //programes kommmer krasa om timmar=0 eftersom du inte kan della med 0

            //övning3
        }
    }
}
