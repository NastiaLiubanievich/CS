using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Order
    {
        private static int _nextId = 1;
        private List<IMenuItem> _items = new();
        public int Id { get; private set; }
        public int TableNumber { get; private set; }
        public OrderStatus Status { get; private set; }

        public Order(int table)
        {
            Id = _nextId++;
            TableNumber = table;
            Status = OrderStatus.New;
        }
        public void AddItem(IMenuItem item)
        {
            if (item is Drink drink)
            {
                if (drink.IsAlcoholic)
                {
                    Console.WriteLine("Замовлення потребує підтвердження віку.");
                }
            }
            _items.Add(item);
            Console.WriteLine($"Додано позицію: {item.Name}");
        }
        public void RemoveItem(IMenuItem item)
        {
            _items.Remove(item);
            Console.WriteLine($"Видалено позицію: {item}");
        }

        public decimal CalculateTotal()
        {
            decimal total_sum = 0;
            foreach (MenuItem item in _items)
            {
                total_sum += item.Price;
            }
            return total_sum;
        }

        public void ChangeStatus(OrderStatus newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"> Змінено статус на: {newStatus}");
        }

        public void DisplayDetailedOrder()
        {
            Console.WriteLine($"\n--- ЗАМОВЛЕННЯ #{Id} ---");
            Console.WriteLine($"Столик: {TableNumber}");
            Console.WriteLine($"Статус: {Status}");
            Console.WriteLine("Позиції:");
            foreach (var item in _items)
            {
                item.Description();
            }
            Console.WriteLine($"Загальна сума: {CalculateTotal()} грн");
            Console.WriteLine("------------------------");
        }
        public void PrintOrderInfo()
        {
            Console.WriteLine($"\nID: {Id} | Стіл: {TableNumber} | Статус: {Status} | Сума: {CalculateTotal()} грн");
            if (_items.Count > 0)
            {
                Console.WriteLine("Позиції:");
                foreach (MenuItem item in _items)
                {
                    Console.WriteLine($"  - {item.Name} ({item.Price} грн)");
                }
            }
        }
    }
}
