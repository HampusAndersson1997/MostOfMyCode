/*using System.Diagnostics;

namespace Properties2
{
    internal class Program
    {
        public class Person
        {
            private string name;

            public string GetName() { return this.name; }
            public void SetName(string name) { this.name = name; }
        }      
        public class PersonProperty
        {
            private string _name; // backing field for "name" property
            public string Name
            { 
                get { return this._name; }
                set { this._name = value; }
            }

            *//*private void SetName(string name)
            {
                this.Name = Name;
            }*//*
        }
        public class PersonGetProperty
        {
            public string Name { get; }
            public PersonGetProperty() { }
            public PersonGetProperty(string name) { this.Name = name; } // only way to "Set" "Name"

            *//*public void Setname(string name)
            {
                this.Name = name;
            }
            public string Name { get; set; }  *//*          
        }
        public class PersonPrivateSet
        {
            public string Name { get; private set; }
            public PersonPrivateSet() { }
            public PersonPrivateSet(string name) { this.Name = name; } // only way to "Set" "Name"

            public void Setname(string name)
            {
                this.Name = name;
            }
            //public string Name { get; set; }  
        }

        static void Main(string[] args)
        {
            Person person = new Person();
            PersonProperty personProperty = new PersonProperty();
            PersonGetProperty personAutoProperty = new PersonGetProperty();
            PersonGetProperty personGetProperty = new PersonGetProperty();
            PersonPrivateSet personPrivateSet = new PersonPrivateSet();


            //SET
            person.SetName("Hampus");
            personProperty.Name = "Hampus";
            personAutoProperty.Name = "Hampus";
            //personGetProperty.Name = "Hampus" // ERROR: No set-accessor.
            //personPrivateSet.Name = "Hampus";// ERROR: No set-accessor.
            personPrivateSet.Setname("Hampus");

            //GET
            Console.WriteLine($"Regular: {person.GetName()}");

            Console.WriteLine($"Property version: {personProperty.Name}");

            Console.WriteLine($"AutoProperty version: {personAutoProperty.Name}");

            Console.WriteLine($"Auto-Property, Private Set: {personPrivateSet.Name}");

        }
    }
}*/
using System.Diagnostics;

namespace ProcessTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.FileName = "http://google.se";
            //proc.StartInfo.Arguments = "hej.txt";
            proc.Start();
            //proc.WaitForExit();

            /*string modified = File.ReadAllText("hej.txt");
            Console.WriteLine(modified);*/


        }
    }
}