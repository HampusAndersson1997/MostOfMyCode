using System;
using System.Numerics;
namespace D21Loopar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExecutePredefinedExamples();
            CalculateProductBetweenUserInput();
            CalculateProductExcludingNumbersBelowOne();
            CalculateProductOfOddNumbersBetweenUserInput();
            CalculateSumBeyondLimit();
            CalculateSumBeforeLimit();
            CalculateSumOfInverses();
        }
        static void ExecutePredefinedExamples()
        {
            DisplaySumBetweenNumbers(-5, 7);
            DisplayProductBetweenNumbers(33, 44);
        }
        static void CalculateProductBetweenUserInput()
        {
            (int start, int end) = GetUserInputForRange("Ange det första talet:", "Ange det andra talet:");
            DisplayProductBetweenNumbers(start, end);
        }
        static void CalculateProductExcludingNumbersBelowOne()
        {
            (int start, int end) = GetUserInputForRange("Ange det första talet igen:", "Ange det andra talet igen:");
            DisplayProductExcludingBelowOne(start, end);
        }
        static void CalculateProductOfOddNumbersBetweenUserInput()
        {
            (int start, int end) = GetUserInputForRange("Ange det första talet för udda produkten:", "Ange det andra talet för udda produkten:");
            DisplayProductOfOddNumbersBetween(start, end);
        }
        static void CalculateSumBeyondLimit()
        {
            int X = GetUserInput("Ange ett tal X: ");
            int Z = X - 1;
            int S = 0;
            while (S <= 100)
            {
                Z++;
                S += Z;
            }
            Console.WriteLine($"Sista talet Z = {Z} och summan S = {S}");
        }
        static void CalculateSumBeforeLimit()
        {
            int X = GetUserInput("Ange ett tal X: ");
            int Z = X;
            int S = 0;
            while (true)
            {
                if (S + Z > 100)
                {
                    Z--;
                    break;
                }
                S += Z;
                Z++;
            }
            Console.WriteLine($"Sista talet Z = {Z} och summan S = {S}");
        }
        static void CalculateSumOfInverses()
        {
            int N = GetUserInput("Ange ett tal: ");
            double sum = 0;
            for (int i = 1; i <= N; i++)
            {
                try
                {
                    sum += GetInverse(i);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
            Console.WriteLine($"Summan av inverserna från 1 till {N} är: {sum}");
        }
        static (int, int) GetUserInputForRange(string message1, string message2)
        {
            Console.WriteLine(message1);
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine(message2);
            int end = int.Parse(Console.ReadLine());
            return (start, end);
        }
        static int GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        static void DisplaySumBetweenNumbers(int start, int end)
        {
            int sum = CalculateSumBetweenNumbers(start, end);
            Console.WriteLine($"Summan av alla tal mellan {start} och {end} är: {sum}");
        }
        static void DisplayProductBetweenNumbers(int start, int end)
        {
            BigInteger product = CalculateProductBetweenNumbers(start, end);
            Console.WriteLine($"Produkten av alla tal mellan {start} och {end} är: {product}");
        }
        static void DisplayProductExcludingBelowOne(int start, int end)
        {
            BigInteger product = CalculateProductExcludingNumbersBelowOne(start, end);
            Console.WriteLine($"Produkten av alla tal mellan {start} och {end} (ignorerar tal mindre än 1) är: {product}");
        }
        static void DisplayProductOfOddNumbersBetween(int start, int end)
        {
            BigInteger product = CalculateProductOfOddNumbersBetween(start, end);
            Console.WriteLine($"Produkten av alla udda tal mellan {start} och {end} är: {product}");
        }
        static int CalculateSumBetweenNumbers(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }
        static BigInteger CalculateProductBetweenNumbers(int start, int end)
        {
            if (start > end) Swap(ref start, ref end);
            BigInteger product = 1;
            for (int i = start; i <= end; i++)
            {
                product *= i;
            }
            return product;
        }
        static BigInteger CalculateProductExcludingNumbersBelowOne(int start, int end)
        {
            if (start > end) Swap(ref start, ref end);
            if (start < 1) start = 1;
            BigInteger product = 1;
            for (int i = start; i <= end; i++)
            {
                product *= i;
            }
            return product;
        }
        static BigInteger CalculateProductOfOddNumbersBetween(int start, int end)
        {
            if (start > end) Swap(ref start, ref end);
            BigInteger product = 1;
            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0) // Checking if the number is odd
                {
                    product *= i;
                }
            }
            return product;
        }
        static double GetInverse(int number)
        {
            if (number == 0)
                throw new DivideByZeroException("Cannot calculate inverse of zero!");
            return 1.0 / number;
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}