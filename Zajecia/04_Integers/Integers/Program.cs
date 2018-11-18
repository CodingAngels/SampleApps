using System;

namespace Integers
{
    /*
    W tym programie porównujemy trzy różne typy całkowite: Int16 (inaczej short),
    Int32 (inaczej int) oraz Int64 (inaczej long), a dokładniej ich maksymalne wartości.
    Maksymalną wartość każdego z typów uzyskamy przez właściwość MaxValue.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Int16    " + Int16.MaxValue);
            Console.WriteLine("short    " + short.MaxValue);

            Console.WriteLine("Int32    " + Int32.MaxValue);
            Console.WriteLine("int      " + int.MaxValue);

            Console.WriteLine("Int64    " + Int64.MaxValue);         
            Console.WriteLine("long     " + long.MaxValue);

            Console.ReadKey();
        }
    }
}
