namespace OK
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            {
                Console.WriteLine("Ange ett heltal: ");
                string input = Console.ReadLine();
                int heltal = Int32.Parse(input);

                if (heltal == 2 || heltal > 5)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.Write("fel");
                }
            }            
        }
    }
}