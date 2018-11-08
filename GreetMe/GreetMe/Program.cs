using System;

namespace GreetMe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wyświetlamy tekst na ekranie i przechodzimy do następnej linii.
            Console.WriteLine("What is your name?");

            /* 
            Wczytujemy linijkę tekstu i zapamiętujemy ją w zmiennej name.
            Nazwy zmiennych powinny zaczynać się małą literą. Jeśli nazwa składa się z kilku wyrazów,
            łączymy te wyrazy i każdy kolejny wyraz zaczynamy wielką literą, np. personName, anotherPersonName.
            Jest to oczywiście tylko przyjęta konwencja, bo dla kompilatora nie ma to znaczenia.
            Kompilator wymaga tylko, aby nazwy zaczynały się literą lub znakiem _ oraz aby zawierały jedynie litery, cyfry lub znak _
            Przykłady dozwolonych nazw: Nazwa, nazwa1, inna_nazwa, _zmienna, _CO_TO_JEST_
            Przykłady niedozwolonych nazw: 2zmienna, inna-zmienna, kwota$, waznaZmienna!, wartosc%, dziwna.zmienna
            */
            string name = Console.ReadLine();

            // Wczytaną uprzednio wartość wypisujemy na ekranie, poprzedzając ją literałem "Hello ".
            // Widzimy tutaj, że operator + dla typu string łączy dwa napisy w jeden.
            // Jest to tzw. konkatenacja, czyli właśnie łączenie napisów.
            Console.WriteLine("Hello " + name);
        }
    }
}
