using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Menu
    {
        private List<IMenuItem> _items = new();

        public void AddItem(IMenuItem item)
        {
            _items.Add(item);
        }

        public void PrintMenu()
        {
            Console.WriteLine("\n===================== МЕНЮ =====================");
            foreach (var item in _items)
            {
                item.Description();
            }
            Console.WriteLine("==================================================\n");
        }

        public IMenuItem? FindByName(string name)
        {
            return _items.FirstOrDefault(i => i.Name == name);
        }
    }
}

