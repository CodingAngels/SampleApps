using System;

namespace Decorate
{
    class Program
    {
        static void Main(string[] args)
        {
            Decorate(args[0] + " " + args[2]);

            Console.WriteLine("Podaj tekst do udekorowania:");
            string tekst = Console.ReadLine();
            Decorate(tekst);
            Console.ReadKey();
        }

        static void Decorate(string parametr)
        {
            Console.WriteLine("#####" + parametr + "#####");
        } 
    }
}
