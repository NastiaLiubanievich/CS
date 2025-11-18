using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Restaurant
{
    public class Drink : MenuItem
    {
        public int Volume { get; private set; }
        public bool IsAlcoholic { get; private set; }

        public Drink(string name, decimal price, int volume, bool isAlcoholic) : base(name, price)
        {
            Volume = volume;
            IsAlcoholic = isAlcoholic;
        }

        public override void Description()
        {
            string alcoholInfo = IsAlcoholic ? "алкогольний" : "безалкогольний";
            Console.WriteLine($"{Name} ({Volume} мл, {alcoholInfo}) - {Price} грн");
        }
    }
}