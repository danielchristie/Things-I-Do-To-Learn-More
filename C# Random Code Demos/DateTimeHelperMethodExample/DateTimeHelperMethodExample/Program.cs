using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeHelperMethodExample {
    // Demonstrating exmples of how the DateTime help module could be used while working with dates
    class Program {

        static void Main(string[] args) {

            //Setup a DateTime Object, creating a new instance of the DateTime class and initialized it to the current system time saved in myValue
            DateTime myValue = DateTime.Now;

            Console.WriteLine(myValue.ToShortDateString()); //Could be long, short...many different format options to chhose from
            Console.WriteLine(myValue.ToShortTimeString());

            Console.WriteLine(myValue.AddDays(3).ToLongDateString()); //This uses a chain of helper methods, the AddDays() and ToLongDateString()
            Console.WriteLine(myValue.AddHours(-3).ToLongDateString()); //subtract 3 hours or could have been minutes or days, etc.

            DateTime myBirthday = new DateTime(1974, 07, 23); //passing in my birthday
            Console.WriteLine(myBirthday.ToShortDateString());

            //How much time has elapsed between the current time and my birthday
            DateTime myBirthday2 = DateTime.Parse("07/23/1974"); //Using DateTime.Parse() to evaluate my birthday and convert it to an appropraite date
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday2); 
            //TimeSpan is the Object to determine time diff and we   
            //called DateTime's helper functions Now and Subtract
            
            Console.WriteLine(myAge.TotalDays);


            Console.ReadLine();
        }
    }
}
