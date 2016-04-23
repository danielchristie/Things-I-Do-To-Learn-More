using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_and_Check_For_Int_Values {

    class Convert_and_Check_For_Int_Values {

        static void Main(string[] args) {
            Console.WriteLine("Please enter a number: ");
            int myNumber;
            string input = Console.ReadLine();

            //Convert the user's string input into an int32 variable
            Int32.TryParse(input, out myNumber);

            //Should receive 0 if TryParse failed becuase there were letters in the user input or it was empty
            if (myNumber == 0) 
                Console.WriteLine("Error, invalid entry! Expected a numeric value.");
            else
                Console.WriteLine("\nYou typed in: {0}", myNumber);

            //variable.GetType() gets the datatype of the data in the variable just for illustration of the data change
            Console.WriteLine("\nThe data type is: {0}", myNumber.GetType());


            Console.WriteLine("Press any key to close...");
            Console.ReadLine();
        }
    }
}
