using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning1
            /*
            bil car = new bil();

            bool inBool = false;
            int year, säten;

            Console.Write("Ange Bilmärke: ");
            car.Model = Console.ReadLine();

            Console.Write("Ange registreingsnummer: ");
            car.RegNbr = Console.ReadLine();

            Console.Write("Ange färg: ");
            car.Color = Console.ReadLine();

            while (!inBool)
            {
                Console.Write("Ange årsmodell: ");
                inBool = int.TryParse(Console.ReadLine(), out year);
                car.Year = year;
            }


            while (!inBool)
            {
                Console.Write("Hur många säten har bilen?: ");
                inBool = int.TryParse(Console.ReadLine(), out säten);
                car.Nbrsäten = säten;
            }

            Console.Write("Du har en: {0} {1}, årsmodell {2} med reg nr {3} som har {4} säten", car.Color, car.Model, car.Year, car.RegNbr, car.Nbrsäten);

            Console.ReadKey();
            */
    
            //övning2

            person folk = new person();
            Console.Write("Ange Namn: ");
            folk.namn = Console.ReadLine();
            Console.Write("Ange efternamn: ");
            folk.efterNamn = Console.ReadLine();
            Console.WriteLine(folk.hellaNamn);
            Console.WriteLine( "ditt namn inehåller: " +folk.antal +"bokstäver");
            Console.ReadKey();

            //övning3
            Console.WriteLine("dd/mm/åå");
            folk.datum = int.Parse(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
