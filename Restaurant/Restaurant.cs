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
        private List<Order> _orders = new();
        public Order CreateOrder(int tableNumber)
        {
            Order newOrder = new Order(tableNumber);
            _orders.Add(newOrder);
            return newOrder;
        }
        public void PrintAllOrders()
        {
            Console.WriteLine("\n=================== УСІ ЗАМОВЛЕННЯ ===================");
            foreach (Order order in _orders)
            {
                order.PrintOrderInfo();
                Console.WriteLine("-----------------------------------------------------");
            }
        }
        public Order? FindOrderById(int id)
        {
            foreach (Order order in _orders)
            {
                if (order.Id == id)
                {
                    return order;
                }
            }

            return null;
        }
    }

}

