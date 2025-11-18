using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Food : MenuItem
    {
        public string Category { get; private set; }

        public Food(string name, decimal price, string category) : base(name, price)
        {
            Category = category;
        }

        public override void Description()
        {
            Console.WriteLine($"{Name} ({Category}) - {Price} грн");
        }
    }
}
