namespace Constructors
{
    internal class Program
    {
        public class Car
        {
            public string colour;
            private string brand;
            private string productionYear;
            public double mileage;

            //public Car() { }

            public Car(
                string colour, 
                string brand, 
                string productionYear, 
                double mileage)
            {
                this.colour = colour;
                this.brand = brand;
                if (int.Parse(productionYear) > 2023) 
                {
                    this.productionYear = "2023";
                }
                else
                {
                    this.productionYear = productionYear;
                }

                this.mileage = mileage;
            }

            public void PrintInfo()
            {
                Console.WriteLine();
            }

            public string GetAge()
            {
                return "";
            }

            public string GetBrand()
            {
                // extra logik
                return this.brand;
            }

            /*public void SetBrand(string brand)
            {
                this.brand = brand;
            }*/
        }

        static string Sanitize(string rawString)
        {
            string sanitized = "";
            //Magic
            return sanitized;
        }


        static void Main(string[] args)
        {
            /*Car myCar = new Car()
            {
                colour = "red",
                brand = "volvo",
                productionYear = "2025",
                mileage = 8000
            };*/

            string prodYear = Console.ReadLine();
            prodYear = Sanitize(prodYear);

            if (int.Parse(prodYear) > 2023)
            {
                prodYear = "2023";
            }

            Car notMyCar = new Car(
                "blue", 
                "volkswagen", 
                "2026", 
                5500
                );

            notMyCar.colour = "red";
            notMyCar.mileage = 20000;

            Console.WriteLine($"Other car's brand: {notMyCar.GetBrand()}");
        }
    }
}