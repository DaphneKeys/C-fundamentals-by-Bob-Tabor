using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");
            
            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born?");
            string city = Console.ReadLine();

            /*
            char[] firstNameArray = firstName.ToCharArray();
            Array.Reverse(firstNameArray);

            char[] lastNameArray = lastName.ToCharArray();
            Array.Reverse(lastNameArray);

            char[] cityArray = city.ToCharArray();
            Array.Reverse(cityArray);

            string result = "";

            foreach (char item in firstNameArray)
            {
                result += item; 
            }

            result += " "; 

            foreach (char item in lastNameArray)
            {
                result += item;
            }

            result += " "; 

            foreach(char item in cityArray)
            {
                result += " ";
            }

            Console.WriteLine("Results " + result);
            */

            
            
            /*
            ReverseString(firstName);
            ReverseString(lastName);
            ReverseString(city);
            */

            DisplayResult(ReverseString(firstName),
            ReverseString(lastName),
            ReverseString(city));

            Console.ReadLine(); 


        }

        private static string ReverseString(string message) //return back to me the reversed string 
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            /*foreach (char item in messageArray)
            {
                Console.Write(item); 
            } */ 

            return String.Concat(messageArray); //because in method we want the method to return string so we use return 
            //concat allow us to pass in individual char to full string
        }

        private static void DisplayResult(
            string reversedFirstName, 
            string reversedLastName, 
            string reversedCity)
        {
            Console.Write("Results: ");
            Console.Write(String.Format("{0} {1} {2}",
                reversedFirstName,
                reversedLastName,
                reversedCity));
        }
        private static void DisplayResult(string message)
        {
            Console.Write("Results: ");
            Console.Write(message); 
        }



    }
}
