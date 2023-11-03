namespace _32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Hampus", 65);
            Human human2 = new Human("Morty", 16);

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();
        }
    }
    class Human
    {
        public String name;
        public int age;

        public Human(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Eat()
        {
            Console.WriteLine(name + " is Eating");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping"); 
        }
    }
}