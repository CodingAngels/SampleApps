using System;

namespace Dates
{
    /*
    Program prezentuje użycie funkcji z parametrem oraz bez, a także funkcji zwracającej wartość
    i nie zwracającej wartości. Pokazuje również przykładowe operacje na dacie za pomocą typu DateTime.
    */
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dzisiaj = PobierzDate();
            Console.Write("Dziś jest ");
            WyswietlDate(dzisiaj);

            /*
            Funkcja AddMonths() dodaje określoną liczbę miesięcy do wybranej daty i zwraca nową datę.
            Oryginalna data pozostaje niezmieniona, czyli po wywołaniu funkcji AddMonths(1) zmienna dzisiaj
            nadal posiada wartość odpowiadającą bieżącej dacie, a data zwiększona od miesiąc jest zapamiętana
            tylko w zmiennej zaMiesiac.
            */
            DateTime zaMiesiac = dzisiaj.AddMonths(1);
            Console.Write("Za miesiąc będzie ");
            WyswietlDate(zaMiesiac);

            /*
            Funkcja AddMonths() może przyjmować jako parametr również wartości ujemne. Wówczas określona liczba
            miesięcy jest odejmowana od wybranej daty. W poniższym przypadku zwrócona wartość odpowiadająca dacie
            występującej miesiąc temu nie jest nigdzie zapamiętywana, ale jest od razu wyświetlana na ekranie.
            */
            Console.Write("Miesiąc temu był ");
            WyswietlDate(dzisiaj.AddMonths(-1));

            Console.WriteLine();
            Console.Write("Podaj jakąś datę: ");
            /*
            Jeśli chcemy wczytać datę z klawiatury, musimy wczytany napis zamienić na typ DateTime.
            Podobnie jak w przypadku typu int, mamy tu dwie możliwości: możemy użyć funkcji Convert.ToDateTime()
            przekazując wczytany napis jako parametr albo użyć funkcji DateTime.Parse(). W naszym przykładzie
            skorzystaliśmy z tej drugiej możliwości.
            Zauważmy, że możemy datę wprowadzać na różne sposoby (w różnych formatach), np. dla polskich ustawień:
            2018-11-25
            2018/11/25
            18-11-25
            18/11/25
            */
            DateTime data = DateTime.Parse(Console.ReadLine());
            
            Console.Write("Podana data to:  ");
            WyswietlDate(data);
            
            Console.ReadKey();
        }

        // Funkcja zwraca dzisiejszą datę uzyskaną poprzez właściwość Today z typu DateTime.
        static DateTime PobierzDate()
        {
            return DateTime.Today;
        }

        /*
        Funkcja przyjmuje jeden parametr, jakim jest data do wyświetlenia i wyświetla podanę datę
        na ekranie. Przekazaną zmienną typu DateTime moglibyśmy przekazać bezpośrednio do funkcji
        Console.Write(), ale wówczas nastąpiłaby niejawna konwersja typu DateTime do typu string
        używająca domyślnego formatowania. W wyniku tego wyświetliłaby się data wraz z czasem
        w formacie odpowiadającym ustawieniom regionalnym systemu.
        Jeśli chcemy mieć wpływ na format wyświetlanej daty, możemy użyć jednej z funkcji konwertujących
        zdefiniowanych w typie DateTime, np. ToShortDateString() lub ToLongDateString(). Obie funkcje
        zamieniają datę na napis używając krótkiego lub długiego formatu daty.
        Na koniec wyświetlamy dzień tygodnia dla podanej daty, korzystając z właściwości DayOfWeek.
        */
        static void WyswietlDate(DateTime data)
        {
            Console.Write(data.ToShortDateString());
            Console.WriteLine(" (" + data.DayOfWeek + ")");
        }
    }
}
