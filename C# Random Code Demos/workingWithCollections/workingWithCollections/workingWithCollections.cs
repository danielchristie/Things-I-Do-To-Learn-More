using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingWithCollections {
    class workingWithCollections {
        static void Main(string[] args) {

            //This demo will illustrate the different styles of collections that can be used and what they can offer
            //Collections typically consist of either Lists, or Dictionaries
            //They essentially an array made easier to work with due to their added features

            /***********************************************
            (Collection Initializer)
            Instantiated two Car objects into being and provided their data 
            This method is really only useful when you are making small collections and 
            require to quickly hard code some information
            
            List<Car> myList = new List<Car>() { //creatng the new Collection
            
            new Car { Make = "Oldsmobile", Model = "Cutlas Supreme", VIN = "NB1243-90342" },
            new Car { Make = "Geo", Model = "Metro", VIN = "XC1353-92432" }
            };
             ***********************************************/

            /***********************************************
            (The Basic Collections)
            One of the very first methods for creating a basic Array where it can do alot all in one line of code
            With this syntax we can initialize an array, add data being comma delimited, and instantiate the Car class into 
            being and thus memory so it can be worked with
            *Initializer Syntax
            *no need for a constructor
            
            Car myCar1 = new Car() { Make = "Oldsmobile", Model = "Cutlas Supreme", VIN = "NB1243-90342" };
            Car myCar2 = new Car() { Make = "Geo", Model = "Metro", VIN = "XC1353-92432" };
            ***********************************************/

            /***********************************************
            (Old method for building a Collection)
            Used to be populer for creating an ArrayList collections...
            ArrayLists are dyamically sized, 
            they provide features like remove and sorting
            
            ArrayList myArrayList = new ArrayList(); //Constructing an ArrayList into being
            myArrayList.Add(myCar1); //loading in the two cars data as a collection
            myArrayList.Add(myCar2);

            foreach (Car car in myArrayList) { //iterating through the ArrayList for all class Car objects's data
                Console.WriteLine(car.Make);
            }
            ***********************************************/

            /***********************************************
            (Dictionary Collection)
            Dictionary<TKey, TValue>  ... this allows us to define unique keys and allows us to search the 
            dictionary for that value. Thus proves very useful in large collections of data

            Dictionary<string, Car> myDictionary = new Dictionary<string,Car>(); //instantiating the object Dictionary into being 
            myDictionary.Add(myCar1.VIN, myCar1); //Loading in the Car object data into the Dictionary collection
            myDictionary.Add(myCar2.VIN, myCar2);

            Console.WriteLine(myDictionary["XC1353-92432"].Make); //Now we can type in a VIN# and it will find the Make
            **********************************************/
            
            Car myCar1 = new Car();  //instantiating r constructing the class objects into being
            myCar1.VIN = "NB1243-90342"; //Providing the data to the class objects using their Getter and Setters
            myCar1.Make = "Oldsmobile";
            myCar1.Model = "Cutlas Supreme";

            Car myCar2 = new Car();
            myCar2.VIN = "XC1353-92432";
            myCar2.Make = "Geo";
            myCar2.Model = "Metro";

            Book myBook = new Book();
            myBook.Author = "Robert Tabor";
            myBook.Title = "Microsoft ,NET XML Web Services";
            myBook.ISBN = "0-000-00000-0";

            /***********************************************
            (Improved Collections Method, called List<T>)
            This example is good for Generic Collections and that offers many features
            and versatility. This version currently, is widely being used
            ***********************************************/
            //Defining what datatype will be for the list object, in this case the Car class datatype
            List<Car> myList = new List<Car>(); //instantiating a List into being and setting its datatype
            myList.Add(myCar1);
            myList.Add(myCar2);

            foreach (Car car in myList) {
                Console.WriteLine(car.Model);
            }


            Console.WriteLine("\nPress any key to close...");
            Console.ReadLine();
        }
    }   //Creat some classes to define their blueprints
    class Car {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
    class Book {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
