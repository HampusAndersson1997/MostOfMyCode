using System;
namespace D23DeLuxe
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string phoneNumber = "(unknown)";
        private int age = 0;
        private string birthMonth = "(unknown)";
        private int birthDay = 0;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void SetPhone(string phone)
        {
            this.phoneNumber = phone;
        }

        public void SetBirthMonthAndDay(string month, int day)
        {
            this.birthMonth = month;
            this.birthDay = day;
        }

        public string GetAstroSign()
        {
            return AstroFortune(birthMonth, birthDay);
        }

        private static string AstroFortune(string month, int day)
        {
            if (month == "januari")
                if (day <= 20) return "Stenbocken"; else return "Vattumannen";
            else if (month == "februari")
                if (day <= 18) return "Vattumannen"; else return "Fiskarna";
            else if (month == "mars")
                if (day <= 20) return "Fiskarna"; else return "Väduren";
            else if (month == "april")
                if (day <= 21) return "Väduren"; else return "Oxen";
            else if (month == "maj")
                if (day <= 21) return "Oxen"; else return "Tvillingarna";
            else if (month == "juni")
                if (day <= 21) return "Tvillingarna"; else return "Kräftan";
            else if (month == "juli")
                if (day <= 22) return "Kräftan"; else return "Lejonet";
            else if (month == "augusti")
                if (day <= 23) return "Lejonet"; else return "Jungfrun";
            else if (month == "september")
                if (day <= 23) return "Jungfrun"; else return "Vågen";
            else if (month == "oktober")
                if (day <= 23) return "Vågen"; else return "Skorpionen";
            else if (month == "november")
                if (day <= 22) return "Skorpionen"; else return "Skytten";
            else if (month == "december")
                if (day <= 21) return "Skytten"; else return "Stenbocken";
            else
                return "okänt";
        }

        public void Print()
        {
            Console.WriteLine($"Name: {firstName} {lastName}, Phone: {phoneNumber}, Age: {age}, Birth Month: {birthMonth}, Birth Day: {birthDay}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person arthur = new Person("Arthur", "Jansson");
            arthur.Print();

            arthur.SetPhone("123-456-789");
            arthur.SetAge(30);
            arthur.SetBirthMonthAndDay("februari", 15);
            arthur.Print();

            Console.WriteLine($"Arthurs stjärntecken: {arthur.GetAstroSign()}");
        }
    }
}
