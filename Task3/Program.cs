namespace Task3
{
    public class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть свій вік:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(ClassifyAge(age));
        }
        public static string ClassifyAge(int age)
        {
            if (age >= 0 && age <= 11)
                return "Ви дитина";
            else if (age >= 12 && age <= 17)
                return "Підліток";
            else if (age >= 18 && age <= 59)
                return "Дорослий";
            else if (age >= 60 && age<=120)
                return "Пенсіонер";
            else
                return "Нереальний вік";
        }
    }
}
