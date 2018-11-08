using System;

namespace Echo
{
    class Program
    {
        /*
         * Nasz program zakłada, że zostanie wywołany z 3 parametrami.
         * Jeśli tak się stanie, każdy parametr zostanie wypisany w nowej linii.
         * Jeśli jednak program będzie wywołany bez parametrów lub z mniejszą liczbą parametrów,
         * wystąpi błąd i program przerwie swoje działanie.
         * Jest to zatem podejście bardzo ryzykowne i nie należy pisać programu w ten sposób.
         * Ale na razie jeszcze nie wiemy, jak się przed tym zabezpieczyć, więc niech tak zostanie :-)
         */
        static void Main(string[] arguments)
        {
            Console.WriteLine(arguments[0]);
            Console.WriteLine(arguments[1]);
            Console.WriteLine(arguments[2]);
        }
    }
}
