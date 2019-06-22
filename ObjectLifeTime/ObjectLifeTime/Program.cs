using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Car.MyMethod();
            /*
            myCar.Make = "Oldmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";
            */

            //Car myThirdCar = new Car("Ford", "Escape", 2005, "White"); //We can do this due to line 86
            /*
            Car myOtherCar;
            myOtherCar = myCar;
            
            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model, 
                myOtherCar.Year, 
                myOtherCar.Color);

            myOtherCar.Model = "98";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            myOtherCar = null;

            //this will not word because we have removed the access for myOtherCar
            //null means indeterminate, not zero , not an empty string. Meaning its undefine. 
            Console.WriteLine("{0} {1} {2} {3}",
            myOtherCar.Make,
            myOtherCar.Model,
            myOtherCar.Year,
            myOtherCar.Color);
            

            myCar = null; 
            // we have removed all the references. Becareful when you want to remove references 
            //because it could hold important references. 
            //The references may be have been removed but there are still memory inside.
            //So its not removed completely. 

            */
            Console.ReadLine(); 

        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set;  }
        /*
        public Car() //example of how to construct a constructor
        {
            //You could load from a configuration file,
            // a database, etc. 
            //this.Make = "Nissan"; 
            Make = "Nissan"; 
            //this. = I want to access. //this. is optional
            //It is part of the declaration of the class itself. 
        }

        //Creating an overloaded constructor
        //What is the point for this constructor?
        //It helps when you are creating a new instances, 
        //you don't want to take many steps to do it outside of this class. 
        //check out line 22, as you type in the code, notice you will have 2 ways to call the constructor
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color; 
        }
        */

        //Creating our own static class
        public static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod");
            Console.WriteLine(Make); //Difference between classes with static members vs instance members
            //instance members = the things we have been working on up on this point.
            //instance and static cannot access each other. 
        }
    }
}
