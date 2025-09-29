namespace Task5
{
    public class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int NumberOfGroups = 4;
            int[][] jaggedArray = new int[NumberOfGroups][];
            jaggedArray[0] = new int[] { 80, 90, 70, 60, 100, 85, 75, 95, 88, 92 , 99};
            jaggedArray[1] = new int[] { 75, 85, 95, 70, 80, 90, 88, 92, 76, 84, 81, 79, 100, 67, 52, 40, 77, 89};
            jaggedArray[2] = new int[] { 60, 70, 80, 90, 65, 75, 85, 95, 68, 78, 88, 98, 66, 72, 74, 83, 55, 99, 49, 93, 81, 86};
            jaggedArray[3] = new int[] { 90, 85, 80, 75, 70, 65, 60, 95, 100, 88, 92, 84, 98, 67, 73, 87, 33, 76, 95};

            PrintGroupStatistics(jaggedArray);
        }
        public static double GetAverage(int[] marks)
        {
            return marks.Average();
        }
        public static int GetMin(int[] marks)
        {
            return marks.Min();
        }
        public static int GetMax(int[] marks)
        {
            return marks.Max();
        }
        public static void PrintGroupStatistics(int[][] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                Console.WriteLine($"Група {i + 1}: Середній = {GetAverage(groups[i]):F1} " +
                $"Мінімальний = {GetMin(groups[i])}, " + $"Максимальний = {GetMax(groups[i])}");
            }
        }
    }
}
