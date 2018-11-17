using System;

namespace AddNumbers
{
    // Zaprezentowane tu rozwiązanie jest poprawne, ale ściśle rzecz biorąc, nie ogranicza
    // nas do wprowadzania jedynie cyfr. Zamiast podać pojedynczą cyfrę, możemy wpisać tu
    // całkiem długą liczbę.
    // W programie 04_AddDigits zaprezentowane jest rozwiązanie działające tylko dla cyfr.
    class Program
    {
        /*
        Zgodnie z ustaleniami, aby ułatwić otrientację w kodzie, przez jakiś czas
        będziemy używać polskich nazw dla tworzonych przez nas zmiennych i funkcji.
        Przypominam jednak, że nie jest to zalecane i należy raczej używać nazw angielskich.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą cyfrę:");
            /*
            Wczytujemy pierwszą cyfrę, a w zasadzie równie dobrze może to być liczba wielocyfrowa,
            bo funkcja ReadLine() pozwala na wpisanie wielu znaków zakończonych klawiszem Enter.
            Ponieważ funkcja ReadLine() zwraca nam wpisaną wartość jako napis - czyli typ string,
            musimy jakoś zamienić to na liczbę. Możemy użyć do tego np. funkcji ToInt32() zdefiniowanej
            w klasie Convert. Zamienia ona napis zawierający liczbę na faktyczną wartość liczbową,
            czyli np. "123" zamieni na 123.
            Jeśli napis nie będzie liczbą (np. "A23") to funkcja zakończy się błędem.
            Funkcja ToInt32() konwertuje napis na typ Int32, czyli inaczej int. Istnieją jeszcze inne funkcje,
            np. ToInt16() lub ToInt64(), które kowertują napisy odpowiednio do typów Int16 czyli short i
            Int64 czyli long. Cyfra na końcu nazwy tych typów oznacza rozmiar danej zmiennej, a dokładnie
            ile bitów zajmuje dana zmienna.
            */
            int cyfra1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Podaj drugą cyfrę:");
            /*
            Tym razem użyjemy innego sposobu zamiany napisu na liczbę, czyli funkcji Parse() zdefiniowanej
            w typie int. Działa ona identycznie - zamienia napis zawierający liczbę na faktyczną wartość liczbową,
            czyli np. "123" zamieni na 123.
            Jeśli napis nie będzie liczbą (np. "A23") to funkcja zakończy się błędem.
            Podobne funkcje zdefiniowane są również w innych typach liczbowych, czyli np. long.Parse() zamienia
            napis zawierający liczbę na wartość typu long, a double.Parse() na wartość typu double itd.
            */
            int cyfra2 = int.Parse(Console.ReadLine());


            int suma = cyfra1 + cyfra2;
            Console.WriteLine("Suma cyfr wynosi " + suma);
            /*
            Zauważcie, że w powyższym poleceniu nie możemy napisać po prostu:
            Console.WriteLine("Suma cyfr wynosi " + cyfra1 + cyfra 2);
            Zresztą sprawdźcie sami, co się stanie, jeśli tak napiszemy.
            Dzieje się tak dlatego, że mielibyśmy wtedy wyrażenie, w którym występuje zmienna typu string
            i 2 zmienne typu int, czyli coś takiego: string + int + int
            Ponieważ nie istnieje niejawna kowersja typu string na typ int, nie możemy nic zrobić
            z pierwszą wartością. Istnieje natomiast niejawna konwersja typu int na typ string
            (bo każdą liczbę możemy wyrazić w postaci napisu, ale odwrotnie już nie - nie każdy
            napis może stać się liczbą. Kompilator dokonuje zatem niejawnej konwersji obu wartości typu int
            na typ string, czyli zamienia nasze zmienne cyfra1 i cyfra2 na napisy. Następnie może już
            wywołać użyty przez nas operator +, który dla typu string powoduje złączenie napisów.
            Czyli nasze cyfry, zamiast być do siebie dodane, byłyby po prostu ze sobą sklejone i doklejone
            do podanego wcześniej literału "Suma cyfr wynosi ".
            Moglibyśmy natomiast napisać to w taki sposób:
            Console.WriteLine("Suma cyfr wynosi " + (cyfra1 + cyfra2));
            Nawiasy - tak jak w matematyce - wymuszają kolejność wykonywania działań, czy w naszym przypadku
            operatorów. Spowodują one, że najpierw obliczone zostanie wyrażenie w nawiasie, czyli (cyfra1 + cyfra2).
            Mamy tu operator + użyty dla dwóch wartości typu int, więc wartości te zostaną po prostu dodane i
            zwrócona zostanie ich suma. Po tej operacji zostanie nam napis "Suma cyfr wynosi " połączony operatorem +
            z wartością typu int (czyli sumą dwóch cyfr). Tym razem także nastąpi niejawna konwersja wartości typu int
            na wartość typu string, czyli nasza suma stanie się napisem. Na koniec operator + połączy nam dwa napisy
            i wynikowy napis zostanie wyświetlony na konsoli.
            */

            Console.ReadKey();
        }
    }
}
