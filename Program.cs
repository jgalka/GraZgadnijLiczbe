using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraZgadnijLiczbe
{
    class Program
    {
        static void Main(string[] args)
        {
            const int a = 0;
            const int b = 200;
            int odp;
            Random generator = new Random();
            int liczba = generator.Next(a, b+1);
            Console.WriteLine("Zgadnij liczbę wylosowaną prze komputer z przedziału od 0 do 200");
            do
            {
                Console.WriteLine("Podaj liczbe:");
                odp = Convert.ToInt32(Console.ReadLine());
                if (odp > liczba)
                    Console.WriteLine("za dużo");
                else if (odp < liczba)
                    Console.WriteLine("za mało");
                else
                    Console.WriteLine("BRAWO !!!");
            }
            while (odp != liczba);
            Console.ReadKey(true);
        }
    }
}
