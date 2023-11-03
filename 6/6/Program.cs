using System;
namespace _6
{
    public class Species
    {
        private string name;
        private string genus;
        private string speciesName;
        private string range;

        public string Name 
        {
            get {  return this.name; } 
            set {  this.name = value; }         
        }
        public string Genus 
        {
            get { return this.genus; }
            set { this.genus = value; }
        }
        public string SpeciesName 
        { 
            get { return this.speciesName; }
            set { this.speciesName = value; }
        }
        public string Range 
        { 
            get { return this.range; }
            set { this.range = value; }
        }

        public Species(string name, string genus, string speciesName, string range)
        {
            this.Name = name;
            this.Genus = genus;
            this.SpeciesName = speciesName;
            this.Range = range;
        }

        public void Print()
        {
            Console.WriteLine($"{Name} ({Genus} {SpeciesName}) - Range: {Range}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Species wildHorse = new Species("Wild horse", "Equus", "ferus", "Mongolia");
            Species mountainZebra = new Species("Mountain zebra", "Equus", "zebra", "Namibia and South Africa");
            Species plainsZebra = new Species("Plains zebra", "Equus", "quagga", "Africa");
            Species africanWildDonkey = new Species("African wild donkey", "Equus", "africanus", "Egypt, Sudan, Eritrea and Etiopia");

            Species[] speciesArray = { wildHorse, mountainZebra, plainsZebra, africanWildDonkey };

            foreach (Species s in speciesArray)
            {
                s.Print();
            }
        }
    }
}