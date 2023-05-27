using System;
using System.Collections.Generic;

namespace Dzielniki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool aplikacjaAktywna = true;

            while (aplikacjaAktywna)
            {



                // Zapytanie użytkownika o liczbę.
                // Zapisać liczbę podaną przez użytkownika
                // sprawdzamy kolejne dzielniki.
                // Jeśli podzielna, to wyświetl komunikat.

                Console.WriteLine("Podaj liczbę do sprawdzenia dzielników");
                long liczba;
                liczba = long.Parse(Console.ReadLine());

                List<long> list = new List<long>();

                Console.WriteLine("Wyszukiwanie liczb...");
                for (long i = 2; i <= liczba / 2; i++)
                {
                    if (liczba % i == 0) // Czy reszta z dzielenia [liczba] przez [i] jest równa 0
                    {
                        list.Add(i);
                    }
                }
                Console.WriteLine("Znaleziono liczby:");


                foreach (long dzielnik in list) // Dla każdego elementu long o nazwie dzielnik z list
                {
                    Console.WriteLine($"{liczba} jest podzielna przez {dzielnik}");
                }
                if (list.Count == 0)
                    Console.WriteLine("Podana liczba jest liczbą pierwszą!");

                if(liczba == 1)
                {
                    Console.Beep(2000, 2);
                }

                Console.WriteLine("To by było na tyle!");
                Console.WriteLine("Czy chcesz podać kolejną liczbe?");
                if (!Console.ReadLine().Equals("tak"))
                    aplikacjaAktywna = false;

                // for , while , foreach
                // 

                Console.ReadKey();
            }
        }
    }
}
