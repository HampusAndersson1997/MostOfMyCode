namespace D139
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine(ContainsDot("fil.txt"));  // true
            Console.WriteLine(ContainsDot("Arne"));  // false
        }
        
        static bool ContainsDot(string text)
        {
            return text.Contains(".");
        }
    }
}