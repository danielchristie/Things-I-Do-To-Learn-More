using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverloadingExample {

    class methOverloadingExample {

        static void Main(string[] args) {

            string strName = "Bob";
            int intNumber = 2;

            // Call this function without and parameters, you call the original method
            // Call this method passing the strName variable and you now call on the 1st overloaded method version
            // Call this method passing the intNumber variable and you now call on the 2nd overloaded method version

            string myValue = callMeFunction(); // Call on the function and retrieve the returned string value
            Console.WriteLine(myValue);

            myValue = callMeFunction(strName); // Call on the 2nd function version and retrieve the new returned string value
            Console.WriteLine(myValue);

            myValue = callMeFunction(intNumber); // Call on the 3rd function version and retrieve the returned int value
            Console.WriteLine(myValue);

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

        private static string callMeFunction() {
            return "You are calling from the original version of the callMeFunction()";
        }

        private static string callMeFunction(string strName) {
            return "You are calling from the 1st overloaded version of the callMeFunction(strName)";
        }

        private static string callMeFunction(int intNumber) {
            return string.Format("You are calling from the {0}nd overloaded version of the callMeFunction(intNumber)", intNumber);
        }

    }
}
