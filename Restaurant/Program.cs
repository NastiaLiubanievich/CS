using System;

namespace Restaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Restaurant restaurant = new Restaurant("Фішкі");

            Menu menu = new Menu();

            menu.AddItem(new Food("Борщ", 150, "Перше"));
            menu.AddItem(new Food("Солянка", 100, "Перше"));
            menu.AddItem(new Food("Відбивна", 80, "Друге"));
            menu.AddItem(new Food("Пюре картопляне", 50, "Гарнір"));
            menu.AddItem(new Food("Паста карбонара", 120, "Друге"));
            menu.AddItem(new Food("Олів'є", 70, "Салат"));
            menu.AddItem(new Food("Грецький", 80, "Салат"));
            menu.AddItem(new Food("Куряча котлета", 70, "Друге"));
            menu.AddItem(new Food("Рис з овочами", 70, "Гарнір"));

            menu.AddItem(new Drink("Вода", 20, 250, false));
            menu.AddItem(new Drink("Сік апельсиновий", 70, 250, false));
            menu.AddItem(new Drink("Сік вишневий", 70, 250, false));
            menu.AddItem(new Drink("Вино біле сухе", 180, 150, true));
            menu.AddItem(new Drink("Сидр", 100, 250, true));
            menu.AddItem(new Drink("Чай зелений", 30, 400, false));
            menu.AddItem(new Drink("Чай чорний", 30, 400, false));
            menu.AddItem(new Drink("Чай фруктовий", 30, 400, false));

            menu.PrintMenu();

            Order order1 = restaurant.CreateOrder(2);
            Console.WriteLine($"Створене нове замовлення для столика №{order1.TableNumber}");
            MenuItem? borschItem = menu.FindByName("Борщ");
            MenuItem? ciderItem = menu.FindByName("Сидр");
            MenuItem? riceItem = menu.FindByName("Рис з овочами");

            if (borschItem != null) order1.AddItem(borschItem);
            if (ciderItem != null) order1.AddItem(ciderItem);
            if (riceItem != null) order1.AddItem(riceItem);

            Console.WriteLine($"Сума замовлення: {order1.CalculateTotal()} грн");

            Console.WriteLine($"\nСтатус: {order1.Status}");
            order1.ChangeStatus(OrderStatus.InProgress);
            order1.ChangeStatus(OrderStatus.Ready);
            order1.ChangeStatus(OrderStatus.Paid);

            Order order2 = restaurant.CreateOrder(3);
            Console.WriteLine($"\nСтворене нове замовлення для столика №{order2.TableNumber}");
            MenuItem? oliveItem = menu.FindByName("Олів'є");
            MenuItem? tea_greenItem = menu.FindByName("Чай зелений");
            MenuItem? kotletaItem = menu.FindByName("Куряча котлета");
            MenuItem? pureItem = menu.FindByName("Пюре картопляне");

            if (oliveItem != null) order2.AddItem(oliveItem);
            if (tea_greenItem != null) order2.AddItem(tea_greenItem);
            if (kotletaItem != null) order2.AddItem(kotletaItem);
            if (pureItem != null) order2.AddItem(pureItem);

            Console.WriteLine($"Сума замовлення: {order2.CalculateTotal()} грн");
            Console.WriteLine($"\nСтатус: {order2.Status}");
            order2.ChangeStatus(OrderStatus.InProgress);

            restaurant.PrintAllOrders();
        }
    }
}


