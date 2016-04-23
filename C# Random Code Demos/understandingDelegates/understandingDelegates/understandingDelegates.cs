using System;

delegate int NumberChanger(int n);
namespace DelegateAppl {
    class TestDelegate {
        static int num = 10;
        public static int AddNum(int p) {
            num += p;
            return num;
        }

        public static int MultNum(int q) {
            num *= q;
            return num;
        }
        public static int getNum() {
            return num;
        }

        static void Main(string[] args) {

            //create delegate instances
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            Console.WriteLine("Please enter a number: ");
            int yourNum;
            string input = Console.ReadLine();

            //Convert the user's string input into an int32 variable
            Int32.TryParse(input, out yourNum);

            //Should receive 0 if TryParse failed becuase there were letters in the user input or it was empty
            if (yourNum == 0)
                Console.WriteLine("\nError, invalid entry! Expected a numeric value.");
            else

                //calling the methods using the delegate objects
                nc1(yourNum);
                Console.WriteLine("\nValue of (10 + {0}) = {1}", yourNum, getNum());
                nc2(yourNum);
                Console.WriteLine("\nValue of (10 * {0}) = {1}", yourNum, getNum());

                Console.WriteLine("Press any key to close...");
                Console.ReadLine();
        }
    }
}
