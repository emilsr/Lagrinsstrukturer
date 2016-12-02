using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lagrinsstrukturer
{
    class Program
    {
        // övning1
        //SortedList är sorterad de är inte Dictionary, Därför tar detr längre tid om du kör ett program som har SortedList. 
        static void Main(string[] args)
        {
            //Skapa en dictionary med int som nyckel och int som värde
            SortedList<int, int> resultat = new SortedList<int, int>();

            //skapa ett Random objekt för att slumpa
            Random random = new Random();

            //Gör tusen upprepnigar
            for (int i = 0; i < 1000; i++)
            {
                //Slumpa tal mellan 1 och 6
                int tal = random.Next(1, 7);

                //Lägg nyckel om denna inte redan finns
                if (!resultat.ContainsKey(tal))
                    resultat.Add(tal, 0);

                //Öka förekomsten av tal
                resultat[tal]++;
            }

            //Visa resultatet
            foreach (KeyValuePair<int, int> kvp in resultat)
            {
                Console.WriteLine("Nyckel: {0} Värde: {1}", kvp.Key, kvp.Value);
            }
            Console.ReadKey();
        }
    }
}