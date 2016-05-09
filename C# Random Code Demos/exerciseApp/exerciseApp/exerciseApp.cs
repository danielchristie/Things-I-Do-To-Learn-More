using System;

namespace exerciseTrainer.DanielChristie {
    /*
     * This app allows the user to define a set of minutes that they plan to exercise. This software will continuously ask the user
     * how much time they have been exercising and keeps a tally of the running total, encouraging the user along throughout their
     * exercise session until the moment the running total reaches or passes the session time the user originally outlined.
     * 
     * This software will also, silently watch for the user the type in "Quit" and promptly exit the application.
     * 
     * This software was developed to demonstrate my understanding of nested loops, nested while loops, input validation techniques
     * even an innovated try/catch method to check the user's input string for integeror other undesired feedback without crashing the 
     * program.
     */
    class exerciseTrainer {	

        static void Main() { // void means that this method will not require nor return any info
            /* This program will allow users to keep track of their time spent while exercising.
            Prompt the user for minutes exercised
            Add minutes exercised to a running total
            Dislay total minutes exercised to the screen
            Repeat program until the user indicates to quit */

            //Keep checking asking for a valid integer until the user complies or quits the program
            int checkNum = 0;
            bool quit = false;
            int totalMin = 0;
            int session = 0;

            while (!quit) {
                standardColor();
                Console.WriteLine("\nEnter the total session minutes you will exercise or type \"Quit\" to exit program: ");
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
                    while (totalMin < session) {
                        standardColor();
                        Console.WriteLine("\nEnter how many minutes you have exercised or \"Quit\" to exit program: ");
                        string input2 = Console.ReadLine();

                        input2 = input2.ToUpper();

                        if (input2 == "QUIT") {
                            standardColor();
                            Console.WriteLine("You have indicated to 'Quit'.",input2);
                            Environment.Exit(0);
                        }
                        //Convert the user's string input into an int32 variable
                        //This method will avoid tripping an exception error
                        Int32.TryParse(input2, out checkNum);
 
                        //Should receive 0 if TryParse failed because there were letters in the user input or it was empty
                        if ((input2 != "QUIT") && (checkNum == 0)) {
                            errorColor();
                            Console.WriteLine("Error, invalid entry! Expected a positive numeric value without decimals or text.");
                            //break; //continue;
                        } 
                        else {
                            totalMin = (totalMin + checkNum);
                            int sessionCalc = (session - totalMin); //Add new minutes for workout to the total minutes worked out this session
                            if (totalMin >= session) {
                                winnerColor();
                                Console.WriteLine("\nCongratulations! You have completed your workout session! \nExcellent work!");
                                quit = true;
                                break;
                            } 
                            else if (sessionCalc == 1) {
                                dialogColor();
                                Console.WriteLine("\nYou have been exercising for {0} minutes. Come on, you only have one minute to go!", totalMin);
                            } 
                            else if (totalMin < (session/2)) {
                                dialogColor();
                                Console.WriteLine("\nYou have been exercising for {0} minutes. You only have {1} minutes to go. Come on, you got this!", totalMin, sessionCalc);
                            } 
                            else if (totalMin == (session/2)) {
                                dialogColor();
                                Console.WriteLine("\nYou have been exercising for {0} minutes. You only have {1} minutes to go. You are at the half way marker, you got this!", totalMin, sessionCalc);
                            }
                            else if (totalMin > (session/2)) {
                                dialogColor();
                                Console.WriteLine("\nYou have been exercising for {0} minutes. You only have {1} minutes to go. You are so close, just a little bit more!", totalMin, sessionCalc);
                            }
                            else {
                                //totalMin = (totalMin + checkNum); //Add new minutes for workout to the total minutes worked out this session
                                dialogColor();
                                Console.WriteLine("\nYou have been exercising for {0} minutes. You only have {1} minutes to go. You can do it!", totalMin, sessionCalc);
                            }
                        } 
                    } //End of inner while loop
            } //End of outter while loop
            standardColor();
            Console.WriteLine("\nPress any key to close..."); //This keeps the console open until the user presses any key to close
            Console.ReadLine();
        } //end of static void main
        
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
        static public void winnerColor() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}