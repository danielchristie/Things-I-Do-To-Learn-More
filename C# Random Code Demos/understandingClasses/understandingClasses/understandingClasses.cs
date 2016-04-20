using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understandingClasses {

    class understandingClasses {

        static void Main(string[] args) {

            //instantiating an instance of the class Car.....This is the actual object of the class Car in the comuter's memory
            //This instance of class Car is now into being or memory under the name myNewCar
            //Additional instances of class Car can also be brought into being with their own 
            //object names and can be manipulated independent from all others 
            Car myNewCar = new Car();

            myNewCar.Make = "Oldsmobile";     //Example of "Setting" the properties of the instance myNewCar object, adhering to the class Car's blueprint
            myNewCar.Model = "Cutlas Supreme";//Setting part is = "Oldsmobile";
            myNewCar.Year = 1986;
            myNewCar.Color = "Silver";

            //Here is an example of how to get the values out of myNewCar to do something with
            Console.WriteLine("{0} - {1} - {2}", 
                    myNewCar.Make,
                    myNewCar.Model,  //This is an example of "Getting" or retrieving value from the class object's properties
                    myNewCar.Color); //In Object Oriented Programming (OOP), this is refered to as "Getters & Setters"

            //This is actually using the datatype values
            //So this is creating a double data type to variable valueOfCar and calling the helper method whatIsTheValue()
            //to retrieve the return value stored in carValue and use it in the myNewCar object instance
            double valueOfCar = whatIsTheValue(myNewCar);//could pass any object instanced of class Car, this time I referenced myNewCar

            //could have been written out on one long line but the above version is easier to read 
            //Console.WriteLine("{0} - {1} - {2}", myNewCar.Make, myNewCar.Model, myNewCar.Color);


            //This is referencing the class Car's own helper function DetermineMarketValue()
            Console.WriteLine("Car's value: {0:C}", myNewCar.DetermineMarketValue()); //{0:C} means format as USD monetary representation. IE: $2,000

            Console.ReadLine();
        }

        //This is an example of a private helper method that may be called on by any class Car object instance anywere within the application
        //where this datatype is relevant but is not directly inherited by all other class Car instances as it isn't within the class Car's code block
        //This makes this helper method, an additional method defined outside of the class Car's blueprint
        //"Car" is the class dataType, "_car" is the input parameter name to work with
        private static double whatIsTheValue(Car _car) {
            double carValue = 100.00;

            //This is assuming that someday someone may come online and look up the car's value
            //they will retrieve its value into the carValue variable
            return carValue;
        }

    }

    class Car {

        //Class Car is not the object......it is only a mere blue print of how the Car object will be built or instantiated

        //Creating the class car by defining some properties of the Car class.
        //Start out by typing "prop" and then press the tab key twice to get the following code snippet
        //Cycle through the snippet with tab tab change data type from into to string and the tab tab to change variable to the following, then
        //press enter enter to go down to the next line and begin the process anew until this is all done.
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //This is an example of a class specific private helper method. This method is inherited automatically to all class object instances of Car
        public double DetermineMarketValue() { //"Car" is the class dataType, "_car" is the input parameter name to work with
            
            double carValue = 100.00;

            //For the "this.Year", the "this" is assumed to mean class Car since it was used within the class Car
            //Could have just used "Year" without the "this" part but it is better to use the full reference of "this.Year" for clarification
            //If this were a large block of code within vast amount of lines, it will make it easier to follow when it is referenced fully
            if (this.Year > 1990) 
                carValue = 10000.0;
            else
                carValue = 2000.0;  //If the car year is newer than 1990 the trade in value is 10000.0 older will be devalued by 8000.00

            return carValue;
        }
    }
}
