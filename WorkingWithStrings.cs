using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "what if I need a\nnew line?";
            //string myString = "Go to your c:\\ drive";
            // string myString = @"Go to your c:\ drive"; 

            //string myString = string.Format("{0} = {1}", "First", "Second" )

            //string myString = string.Format("{0:C}", 123.45); // 0 = 123.45 , C = currency of your current country
            //string myString = string.Format("{0:N}", 1234567890); //add in commas 1,234,567,890.00
            //string myString = string.Format("Percentage : {0:P}", .123); //percentage 12.30%
            //string myString = string.Format("Phone Number: {0:(###) ###-####}", 123456789); //custom format

            //string myString = " That summer we took threes across the board  ";

            //myString = myString.Substring(6,14); //summer we took 
            //myString = myString.ToUpper(); //uppercase
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14); 

            /*
            myString = String.Format("Length before: {0} -- Length after: {1}",
                myString.Length, 
                myString.Trim().Length); //strip off extra spaces beginning and the end 
            */

            /*
            string myString = ""; 
            for (int i=0; i<100; i++)
            {
                myString += "--" + i.ToString(); //ToString similar to concat()
                //concat the "--" and the current value of i as it loops through a 100 times. 
            }
            */

            StringBuilder myString = new StringBuilder(); 

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i); 
            }

            Console.WriteLine(myString);
            Console.ReadLine(); 
        }
    }
}

//Info on standard Numeric Format Strings : https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings 

