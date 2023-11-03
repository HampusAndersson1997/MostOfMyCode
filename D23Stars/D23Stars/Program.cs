namespace D23Stars
{
    public class Star
    {
        private string name;
        private double magnitude;
        private double distance;

        public Star(string name, double magnitude, double distance)
        {
            this.name = name;
            this.magnitude = magnitude;
            this.distance = distance;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}, Magnitude: {magnitude}, Distance: {distance} light years");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Star sirius = new Star("Sirius", -1.46, 8.6);
            sirius.Print();

            Star[] stars =
            {
                new Star("Sun", -26.74, 0.000015813),
                sirius,
                new Star("Canopus", -0.72, 310.6),
                new Star("Rigil Kentaurus (Alfa Centauri)", -0.01, 4.37),
                new Star("Arcturus", -0.04, 36.7)
            };

            Console.WriteLine("\nAll stars:");
            foreach (Star star in stars)
            {
                star.Print();
            }
        }
    }
}