using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Klasy
{
    public class Player
    {
        // Imię
        public string name;

        // Zdrowie
        public int hp = 40;
        public int maxHp = 40;

        // Statystyki
        public int atk = 5;
        public int def = 5;

        // Złoto
        public int gold = 0;
        
        // Doświadczenie
        public int lvl = 1;
        public int exp = 0;
        public int expToLvl = 15;

        public string HUD()
        {
            return $" || {name} || HP: {hp}/{maxHp} | {lvl} Lvl | Exp: {exp}/{expToLvl} | Gold: {gold} |";
        }
    }
}
