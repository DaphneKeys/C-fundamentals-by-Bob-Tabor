using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeClient
{
    class Program
    {
        public class Scape
        {

        
        static void Main(string[] args)
        {

            public string ScrapeWebpage(string url)
            {
                return GetWebpage(url);
            }

            public string ScrapeWebpage(string url, string filepath)
            {
                string reply = GetWebpage(url);

                File.WriteAllText(filepath, reply);
                return reply;
            }

            private string GetWebpage(string url)
            {
                WebClient client = new WebClient();
                return client.DownloadString(url);
            }
            }
        }
    }
}
