using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lagrinsstrukturer
{
    class Program
    {   
        static void Main(string[] args)
        {
            //övning1
            /*
             * //SortedList är sorterad de är inte Dictionary, Därför tar detr längre tid om du kör ett program som har SortedList. 
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
            
            //övning2
            List<int> lista = new List<int>();
            int sum = 0;
            bool stanna = true;
            var i = 0;
            while (stanna)
            {
                lista.Add(int.Parse(Console.ReadLine()));
                sum += lista[i];                
                if (lista[i] == 0)
                {
                    stanna = false;
                }
                Console.WriteLine(sum / lista.Count);
                i++;
            }
            */
            //övning3
            List<string> lista = new List<string>();
            string kort;
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    if (i==1)
                    {
                        lista.Add(kort = "K" +j.ToString());
                        if (j==11)
                        {

                        }
                    }
                    else if (i==2)
                    {
                        lista.Add(kort = "S" + j.ToString());
                    }
                    else if (i == 3)
                    {
                        lista.Add(kort = "H" + j.ToString());
                    }
                    else if (i == 4)
                    {
                        lista.Add(kort = "R" + j.ToString());
                    }
                }   
            }
        }
    }
}