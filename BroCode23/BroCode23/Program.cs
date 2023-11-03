namespace BroCode23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "Hampus";
            int age = 26;

            singHappyBirthday(name, age);
            singHappyBirthday(name, age);
            singHappyBirthday(name, age);

            Console.ReadKey();
        }
        static void singHappyBirthday(String name, int age)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine($"Happy birthday dear {name}!");
            Console.WriteLine($"You are {age} years old!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine();
        }
    }
}