namespace D12_3
{
    using System;

    class Program
    {
        static void Main()
        {
            string binary = "1010001";
            int decimalNumber = BinaryToDecimal(binary);
            Console.WriteLine($"Det binära talet {binary} motsvarar det decimala talet {decimalNumber}.");
        }

        static int BinaryToDecimal(string binary)
        {
            int decimalNumber = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    decimalNumber += (int)Math.Pow(2, binary.Length - 1 - i);
                }
            }
            return decimalNumber;
        }
    }
}