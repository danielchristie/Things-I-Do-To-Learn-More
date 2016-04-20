using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understandingInheritance {

    class understandingInheritance {

        static void Main(string[] args) {

            Car myCar = new Car(); //Building an instance of class Car as myCar
            myCar.Make = "BMW"; //Assigning the values to the inherited traits define by the class Car's blue print
            myCar.Model = "750li";
            myCar.Color = "Black";
            myCar.Year = 2005;

            printCarDetails(myCar); //calling the class Car's helper method and passing in myCar as the parameter

            //As soon as we instantiate the truck class object, it immediately inherits all properties from the 
            //parent class Car. So when we type myTruck. that period will cause the Visual Studio's Intellisense to
            //suggest properties available such as Make, Model, Color, Year, even FormatMe...and a new one specific to
            //the truck class, TowingCapacity
            //This inheritance advntage is to save many lines of code and we may want to use the class car's helper methods
            //and still be able to use helper methods specific to the truck class as well
            Truck myTruck = new Truck();

            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Year = 2006;
            myTruck.Color = "Green";
            myTruck.TowingCapacity = 1200;

            printCarDetails(myTruck); //Here we call on a helper function from class Car that will still offer use to the class Truck
            //The only problem with this is that there is no option to print Truck specific properties like the TowingCapacity
            //So we will need to override the implementation of the class Car's FormatMe() method to suit our extra needs for a Truck class object


            Console.WriteLine("\n Press any key to close this window..."); //This keeps the console open until the user presses enter to close
            Console.ReadLine();
        }

        private static void printCarDetails(Car car) { //Calling on the static helper method to print to console the data assigned to the instanced car class
            Console.WriteLine("Here are the vehicle details: {0}", car.FormatMe());
        }
            class Car { //Parent class

                public string Make {get; set;} //Defining the Class Car's blue prints
                public string Model {get; set;}
                public int Year {get; set;}
                public string Color {get; set;}

                //The "virtual" means that it is fine with being used AS IS or with some overriding properties included
                //If we had used "abstract" instead of "virtual", abstract means, you must override with new properties
                public virtual string FormatMe() {  //Defined a class Car's helper method to set data

                    //Using the string method, FormatMe to define how the data needs to appear to the console
                    return String.Format("{0} - {1} - {2} - {3}",
                        this.Make,
                        this.Model,
                        this.Color,
                        this.Year);

    //Now we want to make a new object, but not a car, a truck.
    //Wont make sense to make whole new class for truck and cut-n-paste all new
    //traits, since trucks and cars do share many of the same traits, instead
    //we can inherit derived traits from the car class and then define some new traits 
    //specific to a truck. So after creating a truck instance, we can override 
    //the parts about a car that doesn't apply to a truck and add in new properties
    //that will be relevant
                }
            }
            //the colon means we will be inheriting properties from class Car for the class Truck
            class Truck : Car {  //Child class
                public int TowingCapacity { get; set; }

                //Overriding a method is possible once defined with "override"
                public override string FormatMe() {  //

                    //So now we can call on FormatMe(), overriding it to get the printout specific for Truck
                    return String.Format("{0} - {1} - {2} Towing Units",
                        this.Make,
                        this.Model,
                        this.TowingCapacity);
                }
            } 
    }
}
