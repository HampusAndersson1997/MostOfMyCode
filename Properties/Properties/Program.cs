namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "valuable_data.txt";
            //string text = "000000111111222\n33333344";
            string[] stringArray = { "555", "66666", "7" };
            /*
            string fileContents = File.ReadAllText(fileName);
            string[] fullArray = {
                fileContents,
                stringArray[0],
                stringArray[1],
                stringArray[2]
            };

            //All of these overwrite the file!!!

            */
            string joined = string.Join(null, stringArray);
                        
            File.WriteAllText(fileName, joined);
        /*File.WriteAllLines(fileName, stringArray);
        //File.WriteAllLines(fileName, fullArray);

        // How do we "append"?

        File.AppendAllLines(fileName, stringArray);

        using (StreamWriter file =  new StreamWriter(fileName))
        {
            foreach (string line in stringArray)
            {
                file.WriteLine(line);
            }*/
        }
    }
}