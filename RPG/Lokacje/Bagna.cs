using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Lokacje
{
    public class Bagna : Lokacja
    {
        public override Lokacja Start()
        {
            Console.WriteLine("Jesteś na bagnach. Ładne jagódki, chcesz je pozbierać?");
            Console.WriteLine("[1] Zbieraj \n[2] Rozejrzyj się \n[3] Wróć");
            string odpowiedz = Console.ReadLine();
            if(odpowiedz == "1" || odpowiedz == "zbieraj")
            {
                return new Miasto();

            }
            else if (odpowiedz == "2" || odpowiedz == "rozejrzyj")
                return null;
            else if (odpowiedz == "3" || odpowiedz == "wroc")
                return null;

            return new Bagna();
        }
    }
}
