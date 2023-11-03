using System;

class D11
{
    static void Main()
    {
        Console.Write("Ange ett heltal: ");
        int num = int.Parse(Console.ReadLine());    

        if (num == 2 && num > 5)
        {
            Console.WriteLine("OK");
        }
        else 
        {
            Console.WriteLine("fel");
        }
    }
}
