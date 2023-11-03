namespace BrodCode21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String[] bilar = new string[3];
            String[] bilar = { "Bmw", "volvo", "saab" };

            /*bilar[0] = "Tesla";
            bilar[1] = "Volvo";
            bilar[2] = "Saab";*/

            /*for (int i = 0; i < bilar.Length; i++)
            {
                Console.WriteLine(bilar[i]);
            }*/

            foreach (String bil in bilar)
            {
                Console.WriteLine(bil);
            }

            /*Console.WriteLine(bilar[0]);
            Console.WriteLine(bilar[1]);
            Console.WriteLine(bilar[2]);*/

            Console.ReadKey();
        }
    }
}