using System;

namespace SquareAreas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Wyświetlamy pola kwadratów o trzech różnych bokach.
            Zwróćcie uwagę, że w programie zawsze podajemy liczby zmiennoprzecinkowe używając kropki jako separatora.
            Kiedy jednak liczba zmiennoprzecinkowa jest zamieniana na typ string, wówczas możemy określić, w jaki
            sposób chcemy ją sformatować. Jeśli tego nie określimy, używane jest formatowanie domyślne czyli takie,
            które używa ustawień systemowych. Jeśli mamy polskie ustawienia systemowe, wartośc liczbowa będzie
            sformatowana za pomocą przecinka. Ale jeśli mamy ustawienia angielskie, będzie sformatowana za pomocą kropki.
             */
            WyswietlPoleKwadratu(0.5);
            WyswietlPoleKwadratu(1);
            WyswietlPoleKwadratu(2.5);

            Console.WriteLine("Naciśnij dowolny klawisz");
            Console.ReadKey();
        }

        // Funkcja przyjmuje jako parametr długość boku kwadratu i wyświetla jego pole.
        static void WyswietlPoleKwadratu(double bok)
        {
            double pole = bok * bok;
            Console.WriteLine("Pole kwadratu o boku " + bok + " wynosi " + pole);
        }
    }
}
