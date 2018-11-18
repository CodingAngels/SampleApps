using System;

namespace AddDigits
{
    // To jest alternatywna wersja aplikacji AddNumbers, która pozwala użytkownikowi
    // jedynie na wprowadzanie pojedynczych cyfr.
    // Dla ułatwienia użyto polskich nazw zmiennych i funkcji, ale przypominam,
    // że nie jest to w praktyce zalecane.
    class Program
    {
        static void Main(string[] args)
        {
            // Jeśli chcemy, aby cyfra wyświetliła się zaraz za napisem, zamiast funkcji WriteLine()
            // powinniśmy użyć funkcji Write(), która wyświetla napis bez przechodzenia do nowej linii.
            Console.Write("Podaj pierwszą cyfrę: ");
            int cyfra1 = WczytajCyfre();

            // Po wczytaniu cyfry chcemy przejść do nowej linii, zatem wywołujemy funkcję WriteLine()
            // bez parametrów - wówczaj niczego ona nie wypisuje, tylko przechodzi od razu do nowej linii.
            Console.WriteLine();

            Console.Write("Podaj drugą cyfrę: ");
            int cyfra2 = WczytajCyfre();
            Console.WriteLine();

            int suma = cyfra1 + cyfra2;
            Console.WriteLine("Suma cyfr wynosi: " + suma);
            
            Console.ReadKey();
        }

        // Funkcja wczytuje z klawiatury pojedynczą cyfrę i zwraca jej wartość liczbową.
        static int WczytajCyfre()
        {
            /*
            Funkcja ReadKey() zwraca nam obiekt zawierający pełną informację o wciśniętym klawiszu.
            Nas interesuje kod wciśniętego klawisza, który uzyskamy z właściwości KeyChar tego obiektu.
            Tutaj przyda nam się znajmość kodów poszczególnych klawiszy, ale możemy też sprawdzić to sami,
            uruchamiając nasz program, wciskając jakś cyfę i zatrzymując program w Debuggerze, aby podejrzeć
            wartość zapamiętaną w zmiennej klawisz. I tak oto:
            Klawisz 0 ma kod 48
            Klawisz 1 ma kod 49
            Klawisz 2 ma kod 50
            Klawisz 3 ma kod 51
            Klawisz 4 ma kod 52
            Klawisz 5 ma kod 53
            Klawisz 6 ma kod 54
            Klawisz 7 ma kod 55
            Klawisz 8 ma kod 56
            Klawisz 9 ma kod 57
            Aby zatem uzyskać z kodu klawisza wartość liczbową cyfry, musimy odjąć od tego kodu 48.
            Po odjęciu otrzymujemy wartość cyfry, którą następnie zwracamy z funkcji.
            */
            char klawisz = Console.ReadKey().KeyChar;
            int cyfra = klawisz - 48;
            return cyfra;
        }
    }
}
