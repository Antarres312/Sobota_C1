using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Lokacje
{
    public class Skrzyzowanie : Lokacja
    {
        public override Lokacja Start()
        {
            Console.WriteLine("Witaj graczu! Gdzie chcesz iść?");
            Console.WriteLine("[1] Miasto \n[2] Bagna \n[3] Wyjście z gry");
            string odpowiedz = Console.ReadLine();
            if(odpowiedz == "1" || odpowiedz == "miasto")
                return new Miasto();
            else if (odpowiedz == "2" || odpowiedz == "bagna")
                return null;
            else if (odpowiedz == "3" || odpowiedz == "wyjscie")
                return null;

            return new Skrzyzowanie();
        }
    }
}
