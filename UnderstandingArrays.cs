using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] number = new int[5];

            number[0] = 4;
            number[1] = 8;
            number[2] = 15;
            number[3] = 16;
            number[4] = 23;
            //number[5] = 42; 

            //Console.WriteLine(number[1]);
            Console.WriteLine(number.Length);
            Console.ReadLine();
            */


            //int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 }; 

            //string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };

            /*
            for (int i = 0; i < names.Length; i++) //prints all strings in the array 
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            */

            /*
            foreach (string name in names) //allows us to read through the string of names 
            {
                Console.WriteLine(name); 
            }
            Console.ReadLine();
            */

            string zig = "You can get what you want out of life " +
                "if you help enough other people get what they want.";

            char[] charArray = zig.ToCharArray(); //long string split into characters 
            Array.Reverse(charArray); //reverse the char 

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine(); 



        }

    }
}
