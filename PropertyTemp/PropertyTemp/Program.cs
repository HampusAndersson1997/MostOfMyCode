namespace PropertyTemp
{
    internal class Program
    {
        public class Person
        {
            private string name; // Backing field
            public string Name //Property
            {
                get { return this.name; }
                set { this.SetName(value); }
            }
            public  birthDate = "YYYY-MM-DD"; // 1999-09-09
            public Person() { }
            public Person(string name, string birthDate)
            {
                this.SetName(name);
                if (birthDate != null) { }
                this.birthDate = birthDate;
            }
            private void SetName(string name)
            {
                if (name == "Hampus")
                {
                    Console.WriteLine("ERROR: Unable to change name; the provided value is reserved for cool people B) .");
                    return;
                }
                this.name = name;
            }
            /*public string GetName()
            {  
                return this.name; 
            }*/
        }
        static void Main(string[] args)
        {
            Person person = new Person("Fredrik");
            Console.WriteLine(person);
            person.Name = "Magnus";
            Console.WriteLine(person.Name);
        }
    }
}