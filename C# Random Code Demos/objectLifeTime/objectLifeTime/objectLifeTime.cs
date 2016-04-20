using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectLifeTime {

    class objectLifeTime {

        static void Main(string[] args) {

            //Creating a new instance object of the Car class named myCar and now that object is officially tangible
            //This is essentially instructing the computer to temporarily reserve a portion of memory or reference for 
            //the Car class instance to work with the data in memory. Like a string to a balloon...let go of the string the balloon
            //will float away and not be accessable anymore. Essentially once .Net is no longer using this reference, it is garbage 
            //collected and removed from the temporary memory and will be no longer accessable
            
            //This is the moment of instanciating an object of the class Car and allows an opportunity to pass in new parameters to take
            //all the properties that have been inherited and add in some new properties
            //This line is commonly referred to as "the Constructor" method
            //Essentially iterator means to build an object of the class Car and set in values or properties, making it tangible and real
            //not just and idea the class blueprint had offered
            Car myCar = new Car();

            //This would be another handle or reference of a tempory reserved block of memory for the same Class object instance,
            //only this time being renamed to myOtherCar opposed to the original name of myCar
            //As long as either is being used, their block of memory, or in the balloon analogy, the string to their balloon can still 
            //is still accessable and the balloon has yet to float away (or garbage collected by .NET)
            //so currently there are three reference objects to the Class instance or block of memory associated to the Car class
            
            
            //Here is an example of overloading, this second instance of a class Car object is inheriting the Make of Nissan
            //Where the second instance of the class Car object will use a method overload of Car() to produce a different Make of Ford
            Car myOtherCar = myCar;

            //this will print "Nissan" just as the original class Car() had assigned in this.Make = "Nissan";
            Console.WriteLine("I am now referencing the class Car's original method - Make: {0}", myOtherCar.Make);

            //This particular instance of the class Car object is referencing the overloaded class Car method instead, since it is 
            //passing in data types that match the overloaded version of the class method's specified parameters
            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");

            //this will print "Ford" and not the original class Car() which had assigned this.Make = "Nissan";
            Console.WriteLine("I am now referencing the class Car's overloaded method - Make: {0}", myThirdCar.Make);

            Console.WriteLine("\n Press any key to close this window..."); //This keeps the console open until the user presses enter to close
            Console.ReadLine();
        }
    }

    class Car {

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double OriginalPrice { get; set; }

        public Car() {
            //you could load this from a configuration file, a database, etc.
            //in this case I am just hard coding a value for this example of a class helper method
            this.Make = "Nissan";
        }

        //This is an example of method overloading
        public Car(string make, string model, int year, string color) {

            Make = make;
            Model = model;
            Year = year;
            Color = color;
        //Class methods defined as Static are done so to become available even without having to instatiate a class object to work with those methods
        //This is why we are able to easily call on .Net's built in class methods without instantiated those class objects everytime. 
        //IE Console.WriteLine() or .ToString() These methods can be called on simply by adding the Using System; at the top and invoking these methods
        //Microsoft during the creation of those classes, had defined them as static members. Their static methods are readily available.
        }
    }
}
