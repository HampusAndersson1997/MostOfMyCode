namespace BroCode27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double result;

            try
            {
                Console.WriteLine("Enter number 1: ");
                x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter number 2: ");
                y = Convert.ToDouble(Console.ReadLine());

                result = x / y;

                Console.WriteLine($"result: {result}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter ONLY numbers PLEASE!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by zero, idiot!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
            }
            finally
            {
                Console.WriteLine("Thanks for visiting!");
            }

            Console.ReadKey();
        }
    }
}