using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace understandEvent_DrivenProgramming {
    class Program {
        static void Main(string[] args) {

            //setting up an event timer
            Timer myTimer = new Timer(2000); // timer's interval is in milliseconds

            myTimer.Elapsed += MyTimer_Elapsed; //Incrementing the elapsed time every 2 seconds
            myTimer.Start();

            Console.WriteLine("\nPress any key to close..."); //Keep printing incremental events until user quits
            Console.ReadLine();
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime); //for each increment event, print to console
        }
    }
}
