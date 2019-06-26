using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { VIN = "A1", Make="BMW", Model="550i", Color=CarColor.Blue, StickerPrice=55000, Year=2009 },
                new Car() { VIN = "B2" , Make="Toyota", Model="4Runner", Color=CarColor.White, StickerPrice=35000, Year=2010 },
                new Car() { VIN = "C3" , Make="BMW", Model="745li", Color=CarColor.Black, StickerPrice=75000, Year=2008 },
                new Car() { VIN = "D4" , Make="Ford", Model="Escape", Color=CarColor.White, StickerPrice=28000, Year=2008 },
                new Car() { VIN = "E5", Make="BMW", Model="550i", Color=CarColor.Black, StickerPrice=57000, Year=2010 }
            };

            // LINQ query 
            /*
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car; 
            */

            /*
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car; 
            */

            // LINQ method 
            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010); //getting all the bmws and year 2010

            //var orderedCars = myCars.OrderByDescending(p => p.Year); //2010 to 2008 


            /*
            var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
            Console.WriteLine(firstBMW.VIN);
            */

            //myCars.ForEach(p => p.StickerPrice -= 3000); //deduct 3000
            //myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            Console.WriteLine(myCars.Exists(p => p.Model == "745li"));

            /*
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1}", car.Year, car.Model, car.VIN); 
            }
            */

            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 2012));

            //Console.WriteLine(myCars.Sum(p => p.StickerPrice));

            Console.WriteLine(myCars.GetType());
            var orderedCars = myCars.OrderByDescending(p => p.Year); //2010 to 200
            Console.WriteLine(orderedCars.GetType()); //show us the data type for orderedCars 
            //Output system.Linq.OrderedEnumerable'2[UnderstandingLINQ.Car,System.Int32] 
            // meaning ordered list of the understandLinq.Car

            var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);
            Console.WriteLine(bmws.GetType());

            var newCars = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select new { car.Make, car.Model };
            Console.WriteLine(newCars.GetType());

            Console.ReadLine();

        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
        public CarColor Color { get; set; }
    }

    enum CarColor
    {
        White,
        Black,
        Red,
        Blue,
        Yellow
    }

}