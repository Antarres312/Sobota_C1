using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Lokacje
{
    public class Miasto : Lokacja
    {
        public override Lokacja Start()
        {
            Console.WriteLine("Chcesz wrócić czy iść do sklepu?");
            Console.WriteLine("[1] Powrót [2] Sklep");
            string odpowiedz = Console.ReadLine();
            if (odpowiedz == "1" || odpowiedz == "powrot")
                return new Skrzyzowanie();
            else if (odpowiedz == "2")
                return null;


            return null;
        }
    }
}
