using System;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //WebClient download String Method / download html string
            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");

            Console.WriteLine(reply);
            //Write to a text file
            File.WriteAllText(@"C:\delicious\WriteText.txt", reply); //replace your location
            Console.ReadLine(); 
        }
    }
}
