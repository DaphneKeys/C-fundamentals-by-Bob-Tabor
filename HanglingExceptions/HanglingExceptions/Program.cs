using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanglingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\delicious\Exampl.txt");
                Console.WriteLine(content);
                
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the name of the file is named correct. e.g Example.txt");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(@"Make sure the directory C:\delicious exists.");
            }
            catch (Exception ex) //general
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message); 
            }
            finally
            {
                //Code to finalize
                //Setting objects to null
                //Closing database connections
                Console.WriteLine("Closing application now...");
            }
            Console.ReadLine();

        }
    }
}
