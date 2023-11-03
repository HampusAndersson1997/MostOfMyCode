using System.Threading.Channels;

namespace D2119
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Dictionary
            Dictionary<string, int> transitionYears = new Dictionary<string, int>
            {
                {"Spanien", 1582 },
                {"Preussen", 1700 },
                {"Sverige", 1753 },
                {"Bulgarien", 1916 },
                {"Rumänien", 1919 }
            };
            //
            while (true)
            {
                //Input
                Console.WriteLine("Ange namet på ett land: \nSkriv 'avsluta' för att avsluta programmet");
                string country = Console.ReadLine().Trim();
                //Output

                if (country.ToLower() == "avsluta")
                {
                    break;
                }

                if (transitionYears.TryGetValue(country, out int year))
                {
                    Console.WriteLine($"{country} övergick till det Gregorianska kalendersystemet år {year}.");
                }
                else
                {
                    Console.WriteLine($"Land finns inte i databasen eller övergick vid ett okänt år.");
                }
            }            
        }
    }
}