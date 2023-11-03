namespace ObjectsAndClasses
{
    internal class Program
    {
        public class Person
        {
            public string name;
            public string phone;
            /*public static string defaultName = "Mrs. Smith";
            public static string defaultPhone = "070-000 00 00";*/

            public void Print()
            {
                Console.WriteLine($"Name: {this.name}\nPhone: {this.phone}");
            }

            /*public static void PrintTemplate()
            {
                Console.WriteLine($"Name: {defaultName}\nPhone: {defaultPhone}");
            }*/

        }

        static void Main(string[] args)
        {
            Person[] phonelist = new Person[100];

            Person p = new Person()
            { name = "Hampus Andersson", phone = "070-111 11 11" };

            Person j = new Person // Person()
            { name = "Jacob", phone = "XXX-XXX XX XX" };

            phonelist[0] = p;
            phonelist[1] = j;
            phonelist[2] = new Person { name = "Hampus", phone = "013-12 12 12" };
            phonelist[3] = new Person { name = "Mohammed", phone = null };
            //phonelist[0] = null;
            //phonelist[2] = null;

            /*for (int i = 0; i < 4; ++i)
            {
                phonelist[i].Print();
            }*/

            foreach (Person person in phonelist)
            {
                if (person != null)
                {
                    person.Print();
                }
            }

            //var response = HttpRequests.Get("https://google.com"); //Psudo code
            // It could be defined that when no response, response will be

            /*if (Response == null)
                {
                return;
                break;
                AbbortConnection();
                }*/

            /*j.name = p.name;

            p.Print();
            j.Print();
            Person.PrintTemplate();

            Math.Sqrt(2);*/
        }
    }
}