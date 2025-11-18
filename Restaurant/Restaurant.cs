using Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Restaurant
{
    public class Restaurant
    {
        public string Name { get; private set; }

        private List<Order> _orders = new();

        public Restaurant(string name)
        {
            Name = name;
        }
        public Order CreateOrder(int tableNumber)
        {
            Order newOrder = new Order(tableNumber);
            _orders.Add(newOrder);
            return newOrder;
        }
        public void PrintAllOrders()
        {
            Console.WriteLine("\n=================== УСІ ЗАМОВЛЕННЯ ===================");
            foreach (var order in _orders)
            {
                order.PrintOrderInfo();
                Console.WriteLine("-----------------------------------------------------");
            }
        }
        public Order? FindOrderById(int id)
        {
            return _orders.FirstOrDefault(o => o.Id == id);
        }
    }
}