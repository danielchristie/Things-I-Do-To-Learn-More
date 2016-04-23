using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understandingLINQ {
    class understandingLINQ {
        static void Main(string[] args) {


            /*This demo is to explain the differences between the Syntax styles for working with the Language Intergrated Query (LINQ)
            (LINQ Query Syntax)
            and
            (LINQ Method Syntax)
            as they perfom the same tasks
            Each one is valid to use but the LINQ Method provides a shorthand but can be more difficult to understand at first glance
            */
            List<Car> myCars = new List<Car>() { //Collection of cars, initialized into memory, and filled with  data
            new Car() { VIN = "A11234522", Make = "BMW", Model = "550i", Year = 1994, StickerPrice = 35000 },
            new Car() { VIN = "B11112232", Make = "Toyota", Model = "550i", Year = 2001, StickerPrice = 32200 },
            new Car() { VIN = "C11022233", Make = "BMW", Model = "745li", Year = 1984, StickerPrice = 35500 },
            new Car() { VIN = "D12846633", Make = "Ford", Model = "Escape", Year = 2012, StickerPrice = 25800 },
            new Car() { VIN = "E10009455", Make = "BMW", Model = "55i", Year = 2014, StickerPrice = 22200 }
            };

            //the var keyword simply says we are not sure what the datatype willbe and we leave Visual Studio to decide
            //what is the right datatype to use

            //LINQ Query Syntax------------------------------------------------
            var search1 = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2014
                       select car;

            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;
            //-----------------------------------------------------------------

            //LINQ Method Syntax-----------------------------------------------
            var search2 = myCars.Where(p => p.Make == "BMW" && p.Year == 2014);
            var orderedCars2 = myCars.OrderByDescending(p => p.Year);
            //-----------------------------------------------------------------


            //This is an example of retrieving the data and printing in to the console
            foreach (var car in orderedCars) { // associated to the LINQ Query Syntax
                Console.WriteLine("Using LINQ Query Syntax: {0} {1} {2}", car.Year, car.Make, car.Model);
            }
            foreach (var car in search1) { // associated to the LINQ Query Syntax
                Console.WriteLine("\nAlso Using the LINQ Query Syntax: {0} {1} \n", car.Model, car.VIN);
            }

            //LINQ Method Syntax uses a Lambda expression which is just a mini method, 
            //meaning gven each item in the collection (p=>),
            //only return those instances of Car where the make is BMW and year is 2014
            //(p.Make == "BMW" && p.Year == "2014"
            foreach (var car in orderedCars2) { //Associated to the LINQ Method Syntax
                Console.WriteLine("Using LINQ Method Syntax: {0} {1} {2}", car.Year, car.Make, car.Model);
            }
            foreach (var car in search2) { //Associated to the LINQ Method Syntax
                Console.WriteLine("\nAlso Using the LINQ Method Syntax: {0} {1}", car.Model, car.VIN);
            }


            //Here is a really good example that shows how LINQ Method Syntax is powerful.
            //With just one line of code I was able to instance a collection, iterate through the collection, 
            //pass in a criteria, and print the formatted results to the console
            myCars.ForEach(p => Console.WriteLine("Using LINQ Method: {0} {1} {2:C}", p.Make, p.Model, p.StickerPrice));
            
            //Another great example:
            Console.WriteLine("Using LINQ Method, displaying the sum of all cars in inventory: {0:C}", myCars.Sum(p => p.StickerPrice));

            
            Console.WriteLine("\nPress any key to close...");
            Console.ReadLine();
        }
    }
    class Car {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int StickerPrice { get; set; }
    }
}
