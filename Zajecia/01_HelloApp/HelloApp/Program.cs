// To jest komentarz jednoliniowy.

/*
 A to jest
 komentarz
 wieloliniowy.
*/

// Poniższa instrukcja pozwala na użycie typów zdefiniowanych w przestrzeni nazw System.
using System;

// Nasz program musi być zawarty w jakiejś przestrzeni nazw - możemy nazwać ją dowolnie.
namespace HelloApp
{
    // Nasz program musi też zawierać jakąś klasę (później wyjaśnimy, co to jest dokładnie). Nazwa też nie ma teraz znaczenia.
    class Program
    {
        /* W naszej klasie musimy umieścić funkcję Main zwracającą void (czyli nic) i przyjmującą jako argument tablicę typu string.
           Nazwa argumentu nie ma znaczenia - ważny jest w tym momencie tylko jego typ.
           Funkcja ta musi posiadać modyfikator static (to również wyjaśnimy sobie później).
           Jest to główna funkcja naszego programu i wykona się ona natychmiast po jego uruchomieniu.
           Po zakończeniu funkcji program również się zakończy. */
        static void Main(string[] args)
        {
            // Odwołujemy się do obiektu konsoli i wywołujemy na nim funkcję WriteLine,
            // która wypisuje podany napis na ekranie i przechodzi do nowej linii.
            Console.WriteLine("Hello Coding Angels!");

            // Jeśli uruchomimy naszą aplikację z Visual Studio poprzez przycisk Start albo klawisz F5, to okno konsoli zamknie się
            // natychmiast po zakończeniu programu.
            // Jeśli uruchomimy ją poprzez klawisz Ctrl + F5, to konsola nie zamknie się, dopóki nie wciśniemy dowolnego klawisza.
        }
    }
}