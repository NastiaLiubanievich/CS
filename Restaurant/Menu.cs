using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Menu
    {
        private List<MenuItem> _items = new();

        public void AddItem(MenuItem item)
        {
            _items.Add(item);
        }

        public void PrintMenu()
        {
            Console.WriteLine("\n===================== МЕНЮ =====================");
            foreach (MenuItem item in _items)
            {
                item.Description();
            }
            Console.WriteLine("==================================================\n");
        }

        public MenuItem? FindByName(string name)
        {
            foreach (MenuItem item in _items)
            {
                if (item.Name.ToLower() == name.ToLower())
                {
                    return item;
                }
            }

            return null;
        }
    }
}



