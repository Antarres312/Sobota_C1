using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Przedmioty
{
    public class Przedmiot
    {
        public string name;
        public int value;
        public int weight;
        public int quantity;
        public bool sellable;

        public Przedmiot(string name, int value, int weight, int quantity, bool sellable)
        {
            this.name = name;
            this.value = value;
            this.weight = weight;
            this.quantity = quantity;
            this.sellable = sellable;
        }
    }
}
