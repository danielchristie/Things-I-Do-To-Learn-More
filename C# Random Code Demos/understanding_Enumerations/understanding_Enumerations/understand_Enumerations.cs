using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understanding_Enumerations {

    class understand_Enumerations {

        static void Main(string[] args) {

            //Enumeration constrains the data forcing it to comply with a small list of possible values 
            //and in doing so it makes the code more reliable and adhering to it's original purpose

            //In the case of the following code block when we chose the Visual Studio built in class method of ForegroundColor, VS's Intellisense
            //Proceeds to offer the ConsoleColor as an option relating to the method ForegroundColor and then offered a list of possible colors to 
            //chose from. This is Microsoft's attempt to enumerate with possible options specific to their class method so thhat I do not break their
            //hard work and intentions with that particular method.
            //So the DarkRed is not just a color it is an enum tpye, defined when the method ForegroundColor was created.
            //Had I attempted to select a color value not on the dropdown list from Intellisense or I may have misspelled a color value and through enumeration,   
            //the error would have been quickly caught during compilation.
            Console.ForegroundColor = ConsoleColor.Red;

            //A programmer can create their own enumerations to ensure that functions and their data types are consistant with ther purpose
            Console.WriteLine("Using red font to print out, Hello World!");


            //So this instantiation of superHero references the enum below it which clearly defines the data types superHero expects
            //As soon as you type in "superHero.", the Intellisense begins to dropdown the list of heros (data types) it is expecting
            superHero myValue;

            Console.WriteLine("Type in a superhero's name to see his nickname: ");
            string userValue = Console.ReadLine();

            //Challenge here is to take the return string from the user, names userValue and convert it to a format type that enum superHero will accept
            //and store that conversion in into the variable named myValue for our Switch Statemet to evaluate

            //The following instructions say to check the enum with TryParse passing in superHero...true means to ignore case sensitivity...out means 
            //if successful, output the enum result into the variable myValue
            //<userHero> means generic data type
            //TryParse is a boolean check...so if TryParse passes, then it is True and then the Parsed enum value will be sent to the myValue
            //this means that if TryParse passes on the userValue from the user, then the value returned into the myValue will be what the superHero
            //enum expects to see
            if (Enum.TryParse<superHero>(userValue, true, out myValue))
            {
                switch (myValue) {
                    case superHero.Batman:
                        Console.WriteLine("\nThe Caped Crusader");
                        break;
                    case superHero.Superman:
                        Console.WriteLine("\nThe Man of Steel");
                        break;
                    case superHero.Spiderman:
                        Console.WriteLine("\nYour Friendly Neighborhood Spider-Man");
                        break;
                    case superHero.GreenLantern:
                        Console.WriteLine("\nThe Emerald Knight");
                        break;
                    default:
                        break;
                }
            } 
            else {
                Console.WriteLine("\nError, does not compute! You have entered an incorrect response.");
            }
            Console.WriteLine("Press any key to close...");
            Console.ReadLine();
           
        }
            
    }
    enum superHero {
        Batman,
        Superman,
        Spiderman,
        GreenLantern
    }
}
