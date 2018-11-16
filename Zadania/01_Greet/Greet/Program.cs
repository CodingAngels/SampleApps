using System;

namespace Greet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zmienna args zawiera tablicę parametrów przekazanych do programu podczas jego uruchamiania.
            // Aby wyświetlić pierwszy parametr, odwołujemy się do elementu tablicy o indeksie 0,
            // ponieważ elementy tablicy numerowane (indeksowane) są od 0.
            Console.WriteLine("Hello " + args[0]);
        }
    }
}
