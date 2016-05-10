using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountToYourNumber {
    class CountToYourNumber {
        static void Main() { 
            /* This program will allow users to define a number for the program to count to.
            Prompt the user for a positive integer
            Increment a count, displaying the count on the screen
            Repeat program until the user indicates to quit */

            //Keep checking asking for a valid integer until the user complies or quits the program
            bool quit = false;
            int session = 0;
            int count = 1;

            while (!quit) {
                standardColor();
                Console.WriteLine("\nEnter the positive number you would like me to count up to or type \"Quit\" to exit program: ");
                string input1 = Console.ReadLine();
                //Convert the user's string input into an int32 variable
                //This method will avoid tripping an exception error
                Int32.TryParse(input1, out session);

                input1 = input1.ToUpper();

                if (input1 == "QUIT") {
                    Console.WriteLine(input1);
                    Environment.Exit(0);
                }
                //Should receive 0 if TryParse failed because there were letters in the user input or it was empty
                if ((input1 != "QUIT") && (session == 0)) {
                    errorColor();
                    Console.WriteLine("Error, invalid entry! Expected a positive numeric value without decimals or text.");
                    quit = false;
                }

                while (count < session) {
                    standardColor();
                    Console.WriteLine(count);
                    count++;
                    if (count == session) {
                        count = 1;
                        session = 0;
                        continue;
                    }
                } //End of inner while loop
            } //End of outter while loop
        } //End of static void main

        static public void standardColor() {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        static public void errorColor() {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;
        }
        static public void dialogColor() {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
