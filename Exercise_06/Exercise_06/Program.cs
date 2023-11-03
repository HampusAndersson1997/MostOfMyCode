using System;

namespace Exercise_06
{
    public class Species
    {
        private string name;
        private string genus;
        private string species;
        private string range;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Genus
        {
            get { return this.genus; }
            set { this.genus = value; }
        }

        public string SpeciesName
        {
            get { return this.species; }
            set { this.species = value; }
        }

        public string Range
        {
            get { return this.range; }
            set { this.range = value; }
        }

        public Species(string name, string genus, string species, string range)
        {
            this.Name = name;
            this.Genus = genus;
            this.SpeciesName = species;
            this.Range = range;
        }

        public void Print()
        {
            Console.WriteLine($"{Name} {Genus} {SpeciesName} - {Range}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Species[] speciesArray =
            {
                new Species("Wild horse", "Equus", "ferus", "Mongolia"),
                new Species("Mountain zebra", "Equus", "zebra", "Namibia and South Africa"),
                new Species("Plains zebra", "Equus", "quagga", "Africa"),
                new Species("African wild donkey", "Equus", "africanus", "Egypt, Sudan, Eritrea and Etiopia")
            };

            foreach (var species in speciesArray)
            {
                species.Print();
            }
        }
    }
}