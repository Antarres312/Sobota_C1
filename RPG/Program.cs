using RPG.Klasy;
using RPG.Lokacje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicjalizacja gry
            Lokacja lokacja = new Skrzyzowanie();
            Player player = new Player();

            // Wprowadzenie do gry
            Console.WriteLine("Witaj w grze!");
            Console.WriteLine("Podaj swoje imię:");
            player.name = Console.ReadLine();


            while(lokacja != null)
            { // Wyświetlanie HUDa
                Console.Clear();
                Console.WriteLine(player.HUD());
                // Wyświetlanie lokacji i wybór nowej lokacji
                Lokacja nowaLokacja = lokacja.Start();
                lokacja = nowaLokacja;
            }
        }
    }
}
