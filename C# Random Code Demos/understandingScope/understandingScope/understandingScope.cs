using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understandingScope {

    class understandingScope {

        private static string k = "";

        static void Main(string[] args) {

            string j = "";

            for (int i = 0; i < 10; i++) {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9) {
                    string l = i.ToString();
                }
            }
            Console.WriteLine("Outside of the for Loop: {0}", j);
            Console.WriteLine("k: {0}", k);
            helperMethod();

            Car car = new Car();

            //pont of this project is to demonstrate the accessability
            //This instance of car cannot use the private Method helperMethod() defined in the Car class since that method was denoted to be "private"
            //This car object can however, access doSomething() of the Car class block since that particular method was denoted to be "public"
            //This demonstrates the different levels of availability determined by the developer whom wrote those methods
            car.doSomething();

            Console.WriteLine("Press any key to close..."); //This keeps the console open until the user presses enter to close
            Console.ReadLine();
        }

        // This variable data is only available since it falls within the veriable scope of "class understandingScope {}" defined at the top
        // If k gets called anywhere outside of this class then the veriable scope is broken and thus the value wihtin k gets garbage collected
        static void helperMethod() {
            Console.WriteLine("k from the helperMethod: ", k);  
            
        }

        class Car { //Demonstrating the accessability modifier differences between public and private 
            public void doSomething() { 
                Console.WriteLine(helperMethod());
            }

            private string helperMethod() {
                return "Hello World!";
            }
        }
    }
}
