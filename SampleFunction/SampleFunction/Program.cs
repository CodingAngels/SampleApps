using System;

namespace SampleFunction
{
    class Program
    {
        /*
         * Funkcja f() miała taką nazwę, ponieważ chciałem dokładnie odwzorować funcję w zapisie matematycznym.
         * W rzeczywistości nie należy tak nazywać funkcji (choć z punktu widzenia składni języka jest to OK).
         * - Po pierwsze, nazwa funkcji powinna odzwierciedlać to, co dana funkcja robi.
         * - Po drugie, nazwy funkcji powinny zaczynać się wielką literą (to tylko konwencja - kompilator tego nie narzuca).
         * - Po trzecie, najlepiej wszystkie elementy w kodzie nazywać po angielsku.
         * 
         * Zgodnie z tymi zaleceniami, funkcja ta mogłaby wyglądać na przykład tak:
         * 
         * static int CountSquare(int value)
         * {
         *     return value * value;
         * }
         */
        static int f(int x)
        {
            return x * x;
        }

        /*
         * W funkcji Main() wywołujemy funcję f() z argumentem 3 i wynik zapisujemy w zmiennej y.
         * Następnie wyświetlamy wynik na konsoli.
         * 
         * Zgodnie z dobrymi praktykami nazewnictwa, nasza funkcja Main mogłaby wyglądać tak:
         * 
         * static void Main(string[] arguments)
         * {
         *     int square = CountSquare(3);
         *     Console.WriteLine(square);
         * }
         */
        static void Main(string[] args)
        {
            int y = f(3);
            Console.WriteLine(y);
        }
    }
}
