namespace D1310
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine(CountSpaces("hej hopp i skogen"));  // returnerar 3
            Console.WriteLine(CountSpaces("ingenting"));  // returnerar 0
        }

        static int CountSpaces(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    count++;
                }
            }
            return count;
        }
    }
}