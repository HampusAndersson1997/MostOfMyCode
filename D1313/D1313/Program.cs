namespace D1313
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine(BinaryToDecimal("100001")); // 33
            Console.WriteLine(BinaryToDecimal("11000"));  // 24
            Console.WriteLine(BinaryToDecimal("1110"));   // 14
            Console.WriteLine(BinaryToDecimal("101011")); /S/ 43
            Console.WriteLine(BinaryToDecimal("10"));     // 2
            Console.WriteLine(BinaryToDecimal("110000")); // 48
            Console.WriteLine(BinaryToDecimal("101100")); // 44
            Console.WriteLine(BinaryToDecimal("11011"));  // 27
            Console.WriteLine(BinaryToDecimal("110"));    // 6
            Console.WriteLine(BinaryToDecimal("100"));    // 4
        }

        static int BinaryToDecimal(string binaryStr)
        {
            return Convert.ToInt32(binaryStr, 2);
        }
    }
}