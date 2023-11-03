namespace BroCode29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String firstName = "Hampus";
            String lastName = "Andersson";
            int age = 26;

            Console.WriteLine($"Hello {firstName} {lastName}.");
            Console.WriteLine($"You are {age,-10} years old.");

            Console.ReadKey();
        }
    }
}