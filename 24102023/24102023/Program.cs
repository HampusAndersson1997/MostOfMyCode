namespace _24102023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textFile = "mytext.txt";
            using (StreamReader file = new StreamReader(textFile))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    // Console.WriteLine(ln);
                    counter++;
                }
                file.Close();
                Console.WriteLine($"");
            }            
        }
    }
}