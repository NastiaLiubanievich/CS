namespace Modul2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var publisher = new MessagePublisher();
            var logger = new FileLogger(@"C:\Users\nasti\OneDrive\Desktop\logPD21.txt");

            publisher.MessageSent += logger.OnMessageSent;

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Input text: ");
                string text = Console.ReadLine();
                publisher.Send(text);
            }
        }
    }
}
