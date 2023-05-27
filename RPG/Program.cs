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

            // Wprowadzenie do gry

            while(lokacja != null)
            {
                Lokacja nowaLokacja = lokacja.Start();
                lokacja = nowaLokacja;
            }
        }
    }
}
