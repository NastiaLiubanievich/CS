namespace Task4
{
    public class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть a:");
            double a=double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть c:");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine(IsValidTriangle(a, b, c));
            Console.WriteLine(GetPerimeter(a, b, c));
            Console.WriteLine(GetArea(a, b, c));
            Console.WriteLine(GetTriangleType(a, b, c));
        }
        public static bool IsValidTriangle(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
                return true;
            if (a<0 && b<0 &&  c<0) 
                return false;
            else
                return false;
        }
        public static double GetPerimeter(double a, double b, double c)
        {
            if (!IsValidTriangle(a, b, c))
                return 0;
            else
                return a + b + c; 
        }
        public static double GetArea(double a, double b, double c)
        {
            if (!IsValidTriangle(a, b, c))
                return 0;
            double p = GetPerimeter(a, b, c)/2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c && c == a)
                return "рівносторонній";
            if (a == b || b == c || c == a)
                return "рівнобедрений";
            if ((a == Math.Sqrt((c * c) - (b * b))) && (b == Math.Sqrt((c * c) - (a * a))) && (c == Math.Sqrt((a * a) + (b * b))))
                return "прямокутний";
            else
                return "довільний";
        }
    }
}
