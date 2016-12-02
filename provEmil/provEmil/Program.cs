using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provEmil
{
    class Program
    {
        static void Main(string[] args)
        {
            //övning4
            Console.WriteLine("Mata in 5 personers vikt: ");
            double[] vikt = new double[5];
            for (int i = 0; i < 5; i++)
            {
                vikt[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Mata in 5 personers längd: ");
            double[] längd = new double[5];
            for (int i = 0; i < 5; i++)
            {
                längd[i] = int.Parse(Console.ReadLine());
            }
            double bmiLängd = längd[0] * 0.01;
            double bmi = vikt[0] / (bmiLängd * bmiLängd);
            double summaAvVikt = 0;
            double summaAvLängd = 0;
            for (int i = 0; i < 5; i++)
            {
                summaAvVikt += vikt[i];
                summaAvLängd += längd[i];
            }
            Console.WriteLine("Medel vikten är: " + summaAvVikt / 5);
            Console.WriteLine("Medel längden är: " + summaAvLängd / 5);

            //För uppgift 5
            if (bmi < 18.5)
            {
                Console.WriteLine("Personens BMI är: " + (Math.Round(bmi, 2)) + " personen är underviktig.");
            }
            else if (18.4 < bmi && bmi < 25)
            {
                Console.WriteLine("Personens BMI är: " + (Math.Round(bmi, 2)) + " normalvikt.");
            }
            else if (24.9 < bmi && bmi < 30)
            {
                Console.WriteLine("Personens BMI är: " + (Math.Round(bmi, 2)) + " övervikt.");
            }
            else if (29.9 < bmi && bmi < 35)
            {
                Console.WriteLine("Personens BMI är: " + (Math.Round(bmi, 2)) + " fetma grad 1.");
            }
            else if (34.9 < bmi && bmi < 35)
            {
                Console.WriteLine("Personens BMI är: " + (Math.Round(bmi, 2)) + " fetma grad 2.");
            }
            else
            {
                Console.WriteLine("Personens BMI är: " + (Math.Round(bmi, 2)) + " fetma grad 3.");
            }
            Console.ReadKey();
        }
    }
}
