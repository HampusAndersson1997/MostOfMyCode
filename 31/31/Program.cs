namespace _31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math.Round(3.14);
            Math.Abs(-3.14);
            Math.Pow(2, 3);

            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();

            Console.ReadLine();

        }
        public static class Messages
        {
            public static void Hello()
            {
                Console.WriteLine("Hello! Welcome to the program");
            }
            public static void Waiting()
            {
                Console.WriteLine("I am waiting for something");
            }
            public static void Bye()
            {
                Console.WriteLine("Bye! Thanks for visiting");
            }
        }
    }
}