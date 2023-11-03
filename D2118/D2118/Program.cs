namespace D2118
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 15)
            {
                Console.WriteLine("Du får köra moppe!");
            }
            else if(age >= 16)
            {
                Console.WriteLine("Du får köra MC!");
            }
            else if(age >= 18)
            {
                Console.WriteLine("Du får köra bil!");
            }
            else
            {
                Console.WriteLine("Du får inte köra något fordon");
            }
        }
    }
}