namespace D146
{
    using System;
    public class Land
    {
        public string namn;
        public string styrestyp;
        public string huvudstad;
        public int invånarantal;

        public void Print()
        {
            Console.WriteLine($"Namn: {namn}");
            Console.WriteLine($"Styrestyp: {styrestyp}");
            Console.WriteLine($"Huvudstad: {huvudstad}");
            Console.WriteLine($"Invånarantal: {invånarantal}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Land sverige = new Land()
            {
                namn = "Sverige",
                styrestyp = "monarki",
                huvudstad = "Stockholm",
                invånarantal = 10512820
            };

            Land tyskland = new Land()
            {
                namn = "Tyskland",
                styrestyp = "republik",
                huvudstad = "Berlin",
                invånarantal = 83783902
            };

            Land sanMarino = new Land()
            {
                namn = "San Marino",
                styrestyp = "republik",
                huvudstad = "San Marino",
                invånarantal = 33600
            };

            sverige.Print();
            tyskland.Print();
            sanMarino.Print();
        }
    }
}