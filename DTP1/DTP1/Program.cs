namespace DTP1
{
    internal class Program
    {
        /*static int sök(int[] iarr, int sökt_värde)
        {
            for (int i = 0; i < iarr.Length; i++)
            {
                if (iarr[i] == sökt_värde)
                    return i;   
            }
            return -1;
        }*/
        static void Main(string[] args)
        {

            // declare command string variable
            string command;
            do
            {
                // read input into command string
                command = Console.ReadLine();
                // execute command string
                if (command == null)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(" "+command);
                }
            }while (command != quit); // 

        /*int[] iarr = { 12, 3, 5, 2, 3, };
        Console.WriteLine("sök på 3 ger " + sök(iarr, 3));
        Console.WriteLine("sök på 3 ger " + sök(iarr, 4));*/
        }
    }
}