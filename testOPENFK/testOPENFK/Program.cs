using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testOPENFK
{
    class Program
    {
        static void Main(string[] args)
        {
            int OutParseValue;
            List<int> Liczby = new List<int>();
            while (Liczby.Count < 10)
            {
                Console.WriteLine($"Hanior podaj liczbę numer {Liczby.Count + 1}");
                if (Int32.TryParse(Console.ReadLine(), out OutParseValue))
                {
                    Liczby.Add(OutParseValue);
                }
                else
                {
                    Console.WriteLine("To nie liczba całkowita hanior dałnie, podaj poprawną.");
                }
            }
            Console.WriteLine("Hanior twoje liczby parzyste: " + String.Join(",", Liczby.Where(x => x % 2 == 0).ToList().OrderBy(x => x)));
            Console.WriteLine("Hanior, a to twoje liczby nieparzyste: " + String.Join(",", Liczby.Where(x => x % 2 != 0).ToList().OrderByDescending(x => x)));
            Console.ReadLine();
        }
    }
}
