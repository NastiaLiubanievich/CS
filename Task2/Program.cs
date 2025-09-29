namespace Task2
{
    public class Program
    {
        static void Main()
        {
            int size = 10;
            int[] Array = GenerateRandomArray(size, 0, 100);
            for (int i = 0; i < Array.Length; i++)
                Console.Write(Array[i] + " ");
            Console.WriteLine();

            Console.WriteLine(GetSum(Array));
            Console.WriteLine(GetAverage(Array));
            Console.WriteLine(GetMin(Array));
            Console.WriteLine(GetMax(Array));
        }
    public static int[] GenerateRandomArray(int size, int min, int max)
        {
            int[] array = new int[size];
            Random array_random = new Random();
            for (int i = 0; i < size; i++) {
                array[i] = array_random.Next(min, max);
            }
            return array;
        }
    public static int GetSum(int[] numbers)
        {
            return numbers.Sum();
        }
    public static double GetAverage(int[] numbers)
        {
            return numbers.Average();
        }
    public static int GetMin(int[] numbers)
        {
            return numbers.Min();
        }
    public static int GetMax(int[] numbers)
        {
            return numbers. Max();
        }
    }
}
