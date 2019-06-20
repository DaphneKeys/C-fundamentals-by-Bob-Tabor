using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString()); 
            //Console.WriteLine(myValue.ToShortDateString()); //just display month date year (shorter version)
            //Console.WriteLine(myValue.ToShortTimeString()); //just display time (shorter version)
            //Console.WriteLine(myValue.ToLongDateString());  //Tuesday, June 20, 2019
            //Console.WriteLine(myValue.ToLongTimeString()); //3:36:35PM 

            /*
            Console.WriteLine(myValue.AddDays(3).ToLongDateString()); //add 3 days  
            Console.WriteLine(myValue.AddHours(3).ToLongTimeString()); //add 3 hours 
            Console.WriteLine(myValue.AddDays(-3).ToLongDateString()); //subtract 3 days
            Console.WriteLine(myValue.Month); //prints the current month 
            
            DateTime myBirthday = new DateTime(1997, 12, 4);
            Console.WriteLine(myBirthday.ToShortDateString());
            */
            DateTime myBirthday = DateTime.Parse("12/4/1997");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);
            Console.ReadLine(); 

            Console.ReadLine(); 
        }
    }
}
