namespace D12
{
    internal class Program
    {
        public static double Cot(float i)
        {
            return 1 / Math.Tan(i);
        }
        static void Main(string[] args)
        {
            for (float i = 0.2f; i <= 2.0f; i += 0.2f)
            {
                float contangent = (float)Cot(i);
                Console.WriteLine($"{i} {Cot(i)}");
            }
        }
    }
}