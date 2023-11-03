using System;

namespace D21Blandat
{
    internal class Program
    {
        public static class MathUtilities
        {
            public static int Sign(int n)
            {
                if (n < 0) return -1;
                if (n == 0) return 0;
                return 1;
            }

            public static int Abs(int n)
            {
                if (n < 0) return -n;
                return n;
            }

            public static bool IsPrime(int n)
            {
                if (n <= 1) return false;
                if (n <= 3) return true;

                if (n % 2 == 0 || n % 3 == 0) return false;

                int i = 5;
                while (i * i <= n)
                {
                    if (n % i == 0 || n % (i + 2) == 0) return false;
                    i += 6;
                }
                return true;
            }

            public static long Factorial(int n)
            {
                if (n < 0) throw new ArgumentException("Factorial is not defined for negative numbers.");
                if (n == 0) return 1;

                long result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
        }

        static double SumOfInverses(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }
            return sum;
        }
        public static class ZodiacUtilities
        {
            public static string GetZodiacSign()
            {
                Console.Write("Ange din födelsemånad (som ett heltal, t.ex. 1 för januari): ");
                int month;
                if (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
                {
                    return "Ogiltig månad.";
                }

                Console.Write("Ange din födelsedag: ");
                int day;
                if (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31)
                {
                    return "Ogiltig dag.";
                }

                switch (month)
                {
                    case 1:
                        return day <= 20 ? "Stenbocken" : "Vattumannen";
                    case 2:
                        return day <= 18 ? "Vattumannen" : "Fiskarna";
                    case 3:
                        return day <= 20 ? "Fiskarna" : "Väduren";
                    case 4:
                        return day <= 20 ? "Väduren" : "Oxen";
                    case 5:
                        return day <= 21 ? "Oxen" : "Tvillingarna";
                    case 6:
                        return day <= 21 ? "Tvillingarna" : "Kräftan";
                    case 7:
                        return day <= 22 ? "Kräftan" : "Lejonet";
                    case 8:
                        return day <= 23 ? "Lejonet" : "Jungfrun";
                    case 9:
                        return day <= 23 ? "Jungfrun" : "Vågen";
                    case 10:
                        return day <= 23 ? "Vågen" : "Skorpionen";
                    case 11:
                        return day <= 22 ? "Skorpionen" : "Skytten";
                    case 12:
                        return day <= 21 ? "Skytten" : "Stenbocken";
                    default:
                        return "Ogiltig månad.";
                }
            }
        }

        // Example usage:
        static void Main(string[] args)
        {
            int number = 5;  // Just an example value

            double inverseResult = SumOfInverses(number);
            Console.WriteLine($"Sum of inverses from 1 to {number} is: {inverseResult}");

            int signResult = MathUtilities.Sign(-5);  // This will return -1
            Console.WriteLine($"Sign of -5 is: {signResult}");

            int absResult = MathUtilities.Abs(-3);  // This will return 3
            Console.WriteLine($"Absolute value of -3 is: {absResult}");

            bool primeResult = MathUtilities.IsPrime(7); // This will return true
            Console.WriteLine($"Is 7 a prime number? {primeResult}");

            long factorialResult = MathUtilities.Factorial(6); // This will return 720
            Console.WriteLine($"6! is: {factorialResult}");

            string zodiacSign = ZodiacUtilities.GetZodiacSign();
            Console.WriteLine($"Du är född i stjärntecknet: {zodiacSign}");
        }
    }
}
