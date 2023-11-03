namespace D1312
{
    using System;

    class Program
    {
        static void Main()
        {
            string S1 = "universitetslektor";
            string T1 = Caesar(S1);
            Console.WriteLine(S1 + " => " + T1);

            string S2 = "telegrafstation";
            string T2 = Caesar(S2);
            Console.WriteLine(S2 + " => " + T2);
        }

        static string Caesar(string text)
        {
            char[] charArray = text.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                // Omvandla char till int, addera 1, och gör sedan en typecast tillbaka till char
                charArray[i] = (char)((int)charArray[i] + 1);
            }
            return new string(charArray);
        }
    }
}