using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Övning_inför_prov_1
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.Write("Path to dir: ");
            string dir = Console.ReadLine();
            printFiles(dir);
        }

        static void printFiles(string path)
        {
            try
            {
                string[] files = Directory.GetFiles(path);

                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                string[] dirs = Directory.GetDirectories(path);

                foreach (string dir in dirs)
                {
                    printFiles(dir);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Got error: " + e);
            }

        }

    }
}


