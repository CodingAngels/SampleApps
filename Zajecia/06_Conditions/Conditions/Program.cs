using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wybierz działanie (+, -, *, /): ");
            string dzialanie = Console.ReadLine();

            Console.Write("Podaj liczbę 1: ");
            long liczba1 = long.Parse(Console.ReadLine());

            Console.Write("Podaj liczbę 2: ");
            long liczba2 = long.Parse(Console.ReadLine());

            if (dzialanie == "+")
            {
                Console.Write(liczba1 + dzialanie + liczba2 + "=");
                Console.WriteLine(liczba1 + liczba2);
            }
            else if (dzialanie == "-")
            {
                Console.Write(liczba1 + dzialanie + liczba2 + "=");
                Console.WriteLine(liczba1 - liczba2);
            }
            else if (dzialanie == "*")
            {
                Console.Write(liczba1 + dzialanie + liczba2 + "=");
                Console.WriteLine(liczba1 * liczba2);
            }
            else if (dzialanie == "/")
            {
                Console.Write(liczba1 + dzialanie + liczba2 + "=");
                Console.WriteLine(liczba1 / liczba2);
            }
            else
            {
                Console.WriteLine("Nierozpoznane działanie.");
            }

            Console.Write("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}
