using System;

namespace Area
{
    class Program
    {
        /*
        Definiujemy naszą funkcję obliczającą pole koła.

        Możemy zdefiniować ją przed fnkcją Main() albo za nią - nie ma to znaczenia.
        Tak zdefiniowana funkcja będzie widoczna dla wszystkich innych funkcji w klasie Program,
        czyli tej klasie, w której funkcja jest zdefiniowana.
        Teoretycznie moglibyśmy zdefiniować tę funkcję wewnątrz funkcji Main(), jednak wówczas
        funkcja ta byłaby widoczna tylko w funkcji Main().
        Akurat w naszym przypadku nie ma to większego znaczenia, bo i tak wywołujemy naszą funkcję
        tylko z funkcji Main(). Generalnie jednak rzadko definiuje się funkcję wewnątrz innej funkcji,
        więc nie będziemy tego robić w ten sposób.
        
        Dla nazw funkcji obowiązują takie same wymagania komilatora jak dla nazw zmiennych, czyli możemy
        używać liter, cyfr i znaku _ i nazwa musi zaczynać się od litery lub znaku _.
        Konwencja nazewnicza jest również podobna, ale tym razem zaczynamy od wielkiej litery zarówno pierwszy
        wyraz jak i każdy kolejny.
        Startajmy się, aby nazwa metody mówiła o tym, co ta metoda robi, a najlepiej, żeby brzmiała jak polecenie,
        np. ObliczPoleKola, WczytajLinie, ObliczSume itd.
        Starajmy się też używać nazw angielskich, czyli CalculateCircleArea, ReadLine, CalculateSum itd.

        Parametry funkcji są również zmiennymi, więc obowiązują je normalne zasady takie jak dla zmiennych.
        Te nazwy powinny być również jak najbardziej zrozumiałe - nie każmy się komuś domyślać, do dany parametr oznacza.

        W naszym przypadku zarówno promień koła jak i pole mogą być liczbami rzeczywistymi, więc najlepiej użyć typu double.
        */
        static double CalculateCircleArea(double radius)
        {
            // Korzystamy ze wzoru na pole koła: PI * r * r
            // Stałą PI pobieramy z klasy Math (a dokładnie System.Math, ale ponieważ na początku pliku napisaliśmy using System,
            // nie musimy już teraz za każdym razem pisać System przed nazwą klas zawartych w przestrzeni nazw System.
            // Czyli zamiast System.Math albo System.Console możemy napisać po prostu Math albo Console.
            // Inaczej mówiąc klauzula using System na początku pliku mówi o tym, że będziemy używać klas z przestrzeni nazw System.
            return Math.PI * radius * radius;
        }

        static void Main(string[] args)
        {
            // Obliczamy teraz pola trzech różnych kół i zrobimy to na 3 sposoby.

            /*
            Definiujemy zmienną radius i przypisujemy jej wartość 1, bo pierwsze koło ma promień 1.
            Zwróćmy uwagę, że chociaż zmienna ta nazywa się tak samo jak parametr fukcji CalculateCircleArea(),
            są to zupełnie niezależne zmienne. Każda zmienna jest widoczna tylko w określonym zakresie,
            w zależności od miejsca, w którym została zadeklarowana.
            Parametr funkcji jest widoczny tylko wewnątrz tej funkcji.
            Zmienna zadeklarowana wewnątrz funkcji (tzw. zmienna lokalna) też jest widziana tylko wewnątrz funkcji.
            A zatem zmienna radius będąca parametrem funkcji CalculateCircleArea() nie jest widoczna w funkcji Main(),
            a zmienna lokalna radius zadeklarowana w funkcji Main() nie jest widoczna w funkcji CalculateCircleArea().
            */
            double radius = 1;

            // Wywołujemy funkcję CalculateCircleArea() przekazując jako parametr zmienną radius.
            // Wynik funkcji zapisujemy w zmiennej area.
            double area = CalculateCircleArea(radius);

            // Na koniec wypisujemy wartośc zmiennej area (czyli obliczone pole koła) na konsoli.
            Console.WriteLine(area);

            // Teraz moglibyśmy zadeklarować kolejną zmienną, np. radius2, która przechowywałaby promień drugiego koła.
            // Ponieważ jednak mamy już zadeklarowaną zmienną radius i przechowywana w niej wartość nie jest nam już potrzebna,
            // możemy użyć tej samej zmiennej ponownie. Przypiszmy zatem do niej wartość promienia drugiego koła.
            radius = 0.5;

            // Wywołujemy ponownie funkcję CalculateCircleArea() znów przekazując zmienną radius jako parametr.
            // Tym razem jednak zmienna ta ma wartość 0.5 a nie 1 jak poprzednio.
            // Moglibyśmy zadeklarować nową zmienną, np. area2, która przechowałaby wynik funkcji, czyli pole drugiego koła.
            // Moglibyśmy również przypisać ten wynik do istniejącej już zmiennej area, ponieważ wartość tej zmiennej już
            // nie jest nam potrzebna.
            // Ale równie dobrze możemy wynik fukcji wypisać od razu na konsoli, czyli przekazać jako parametr do funkcji Console.WriteLine().
            Console.WriteLine(CalculateCircleArea(radius));

            // Pole trzeciego koła policzymy jeszcze prościej.
            // Możemy bowiem wywołać funkcję CalculateCircleArea() bez deklarowania żadnych zmiennych.
            // Po prostu jako parametr funkcji wstawimy promień trzeciego koła, czyli literał 25.12345
            // Wynik funkcji również wyświetlimy od razu na konsoli.
            Console.WriteLine(CalculateCircleArea(25.12345));

            // Żeby konsola nie zamknęła się po zakończeniu programu (żebyśmy mogli odczytać wyniki),
            // użyjemy fukcji Console.ReadKey(). Funkcja ta wczytuje pojedynczy klawisz wciśnięty na klawiaturze.
            // Dopóki jakiegoś klawisza nie wciśniemy, funkcja będzie czekać.
            Console.ReadKey();
        }
    }
}
