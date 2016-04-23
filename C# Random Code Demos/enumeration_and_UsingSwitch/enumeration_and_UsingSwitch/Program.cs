using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeration_and_UsingSwitch {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Type in a super hero's name to see his nickname: ");
            string userValue = Console.ReadLine();

            //Demonstrating a Switch "case" Statement
            //Shortcut is type switch then tab key twice and Intellisense produces a basic Switch templet
            //The Switch is good where an If statement would have been very verbose
            switch(userValue.ToUpper()) { 
                case "BATMAN":
                    Console.WriteLine("Caped Crusader");
                    break;
                case "SUPERMAN":
                    Console.WriteLine("Man of Steel");
                    break;
                case "GREENLANTERN":
                    Console.WriteLine("Emerald Knight");
                    break;
                default:
                    Console.WriteLine("Does not compute");
                    break;
            }
            Console.ReadLine();

            //Demonstrating an If then Statement
            //The advantage of the If statement is that you can get more indepth with comparison details not possible in the Switch statement
            //as in the following block of If statement code:
            //In the followng If statement, we are able to check for many conditions on one line such as 
            //the specific value of 42 OR wihin the range from 1 and 90
            Console.WriteLine("\nPick a number between 1 and 100: ");
            string userValue2 = Console.ReadLine();

            int compareValue = int.Parse(userValue2);

            //Enumeration constrains the data forcing it to comply with a small list of possible values 
            //and in doing so it makes the code more reliable
            if ((compareValue < 1) || (compareValue > 100))
                Console.WriteLine("I am sorry, the number you chose was not between 1 and 100!");
            else if ((compareValue == 42) || (compareValue > 90))
                Console.WriteLine("You guessed one of the special numbers!");
            else
                Console.WriteLine("I am sorry, you didn't guess one of the special numbers!");
            

            Console.WriteLine("Press any key to close..."); //This keeps the console open until the user presses enter to close
            Console.ReadLine();
        }
    }
}
