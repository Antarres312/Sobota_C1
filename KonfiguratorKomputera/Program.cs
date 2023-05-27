using System;

namespace KonfiguratorKomputera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string procesor;
            string grafika;
            string plyta;
            string ram;
            string dysk;

            // 1. wybór procesora
            // 2. grafika
            // 3. płyta główna
            // 4. ram
            // 5. Dysk
            // 6. po wyborze, podsumowanie i całkowita cena

            // Procesor
            Console.WriteLine("Wybierz procesor: \n  " +
                "1. Intel I9 13000 \n 2. Ryzen 9 5750 \n " +
                "3. Intel Pentium E2160");
            procesor = Console.ReadLine();

            // switch (wyrażenie) 
            // {
            // case wartośćWyrażenia:
            //      polecenie lub polecenia;
            //      break;
            // case wartośćWyrażenia:
            //      polecenie lub polecenia;
            //      break;
            // default:                          -- OPCJONALNE
            //      polecenie lub polecenia;    
            //      break;
            // }

            procesor = procesor.Trim(); // usuwa spacje i białe znaki
            procesor = procesor.ToLower(); // Zmienia na małe litery [IntelI9 -> inteli9]

            switch (procesor)
            {
                case "1":
                case "i9":
                    Console.WriteLine("Wybrałeś I9 13000");
                    break;
                case "2":
                case "ryzen":
                case "ryzen9":
                    Console.WriteLine("Wybrałeś procesor Ryzen 9");
                    break;
                case "3":
                case "intel pentium":
                case "pentium":
                    Console.WriteLine("Wybrałeś Intel Pentium");
                    break;
                default:
                    Console.WriteLine("O nie, popsułeś!");
                    break;
            }

            // Grafika
            Console.WriteLine("Wybierz kartę graficzną:\n1. GTX 1650Ti \n2. Nvidia GT 750 \n3. RTX 2060Ti Super");
            // switch do grafiki
            grafika= Console.ReadLine();
            grafika = grafika.Trim();
            grafika = grafika.ToLower();
            switch (grafika)
            {
                case "1":
                    Console.WriteLine("Wybrałeś 1. GTX 1650Ti");
                    break;
                case "2":
                    Console.WriteLine("Wybrałeś 2");
                    break;
                case "3":
                    Console.WriteLine("Wybrałeś 3");
                    break;
                default:
                    Console.WriteLine("Nie wiemy co to.");
                    break;
            }


            Console.ReadKey();

        }
    }
}
