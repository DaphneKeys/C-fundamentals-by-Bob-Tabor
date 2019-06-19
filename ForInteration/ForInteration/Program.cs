using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForInteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++) //begin by declaring i=0 , as long i is less than 10(in other words, as long i<10 is true, then interate by 1 
            {
                //Console.WriteLine(i); 
                if (i == 7)
                {
                    Console.WriteLine("Found Seven!");
                    break; 
                }

            }
            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue); 
            }
            Console.ReadLine();
        }

			
    }
}
