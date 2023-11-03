namespace D1311
{
    using System;

    class Program
    {
        static void Main()
        {
            string text = "Hello, World!";
            char[] charArray = StringToCharArray(text);

            // Skriv ut elementen i char-arrayen
            for (int i = 0; i < charArray.Length; i++)
            {
                Console.Write(charArray[i] + " ");
            }
        }

        static char[] StringToCharArray(string text)
        {
            return text.ToCharArray();
        }
    }
}