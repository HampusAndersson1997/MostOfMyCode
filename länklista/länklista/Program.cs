using System;
using System.Diagnostics;

namespace länklista
{
    internal class Program
    {
        class Link
        {
            public string topic, site, title, url;
            public Link(string topic, string site, string title, string url)
            {
                this.topic = topic; this.site = site; this.title = title; this.url = url;
            }
            public void Print()
            {
                Console.WriteLine($"topic:  {this.topic}"); 
                Console.WriteLine($"site:   {this.site}");  
                Console.WriteLine($"title:  {this.title}"); 
                Console.WriteLine($"url:    {this.url}");   
            }
        }
        static Link[] linkList = new Link[30];
        static int linkListInsertPosition;
        static void Main(string[] args)
        {
            string[] command;
            do 
            {
                Console.Write("> ");
                command = Console.ReadLine().Split(' ');
                // TODO: vad händer om Console.ReadLine() ger tom sträng? 
                if (command[0] == "load")
                {
                    string fileName;
                    if (command.Length == 1)
                        fileName = "weblinks.lis";
                    else
                        fileName = command[1];
                    linkList = new Link[30];
                    linkListInsertPosition = 0;
                    using (StreamReader sr = new StreamReader(fileName)) // FIXME: obefintlig fil fångas in
                    {
                        string line;
                        // TODO: frän grej: räkna antal inlästa sajter
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] linkdata = line.Split(";");
                            Link link = new Link(linkdata[0], linkdata[1], linkdata[2], linkdata[3]);
                            linkList[linkListInsertPosition++] = link;
                        }
                    }
                    // TODO: frän grej: räkna antal inlästa sajter
                }
                else if (command[0] == "edit")
                {
                    string fileName;
                    if (command.Length == 1)
                        fileName = "weblinks.lis";
                    else
                        fileName = command[1];
                    Process notepad = new Process();
                    notepad.StartInfo.FileName = "notepad.exe";
                    notepad.StartInfo.Arguments = $@"C:\Users\Hampus\source\repos\länklista\länklista\bin\Debug\net7.0\{fileName}";
                    notepad.Start();
                    Console.Write("Press emter to continue!");
                    Console.ReadLine(); // Väntar tills vi trycker [Enter]
                    linkList = new Link[30];
                    linkListInsertPosition = 0;
                    Console.WriteLine("Läser om filen!");
                    using (StreamReader sr = new StreamReader(fileName)) // FIXME: obefintlig fil fångas in
                    {
                        string line;
                        // TODO: frän grej: räkna antal inlästa sajter
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] linkdata = line.Split(";");
                            Link link = new Link(linkdata[0], linkdata[1], linkdata[2], linkdata[3]);
                            linkList[linkListInsertPosition++] = link;
                        }
                    }
                }
                else if (command[0] == "list")
                {
                    if (command.Length > 2 && command[1] == "topic")
                    { 
                        string topic = command[2];
                        for (int i = 0; i < linkListInsertPosition; i++)
                        {
                            if (topic == linkList[i].topic)
                            {
                                Console.WriteLine($"LÄNK {i}: ");
                                linkList[i].Print();
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < linkListInsertPosition; i++)
                        {
                            Console.WriteLine($"LÄNK {i}: ");
                            linkList[i].Print();
                        }
                    }                    
                }
                else if (command[0] == "open")
                {
                    
                        if (command.Length == 3 && command[1] == "topic")
                        {
                            string topic = command[2];
                            for (int i = 0; i < linkListInsertPosition; i++)
                            {
                                if (topic == linkList[i].topic)
                                {
                                    Console.WriteLine($"LÄNK {i}: ");
                                    linkList[i].Print();
                                    ProcessStartInfo startInfo = new ProcessStartInfo();
                                    startInfo.FileName = @"C:\Users\Hampus\AppData\Local\Microsoft\WindowsApps\MicrosoftEdge.exe";
                                    startInfo.Arguments = linkList[i].url;
                                    Process.Start(startInfo);
                                }
                            }
                        }
                        else if (command.Length == 2)
                        {
                            int indexToOpen = int.Parse(command[1]);
                            // FIXME: hänger sig om indexToOpen out of bounds!
                            Console.WriteLine($"index to open {indexToOpen}");
                            Console.WriteLine($"index to open {linkList[indexToOpen].url}");
                            ProcessStartInfo startInfo = new ProcessStartInfo();
                            startInfo.FileName = @"C:\Users\Hampus\AppData\Local\Microsoft\WindowsApps\MicrosoftEdge.exe";
                            startInfo.Arguments = linkList[indexToOpen].url;
                            Process.Start(startInfo);
                        }
                    else
                    {
                        Console.WriteLine($"Open what?");                  
                    }
                }
            }while (command[0] != "quit");
        }
    }
}