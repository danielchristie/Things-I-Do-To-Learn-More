using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptionsDemo {
    class HandlingExceptionsDemo {
        static void Main(string[] args) {


            //The point of this demo is to show that in a perfect world, values.txt
            //should be available, but for this demo we will intentionally rename the values.txt to values1.txt
            //This would produce a FileNotFound Exception and crash the program.
            //This demo will show how I will handle this scenerio so the program will continue without an error and 
            //the user will be none-the-wiser...
            //in this case I delibertly renamed the values.txt to values1.txt to produce an exception
            //To approach this concern, we will implement a TRY CATCH block.

            try {
                //Creating the constructor for the SreamReader object
                StreamReader myReader = new StreamReader("values.txt"); 
                string line = "";

                while (line != null) {  //While line has information inside of it, do the following...
                    line = myReader.ReadLine(); //Open values.txt and read one line, store that into line
                    if (line != null)  //As long as there is still data inside of line, do the following
                        Console.WriteLine(line); // write the contents stored in line to the console
                }

                myReader.Close();  //Finally once there is no data in line the loop is over and we close values.txt file
            }

                //Attempting to error handle all of the likely causes first and then a general exception last
            catch (DirectoryNotFoundException e) { //Directory Not Found
                //Providing a more clear description of the error so an Enduser will be able to better understand what went wrong
                //If left to Visual Studio, the error would be very non descriptive for an Enduser
                Console.WriteLine("The directory containing the file values.txt cannot be found or has been renamed. \n{0}", e.Message);
            } 
            catch (FileNotFoundException e) { //File Not Found
                //Providing a more clear description of the error so an Enduser will be able to better understand what went wrong
                //If left to Visual Studio, the error would be very non descriptive for an Enduser
                Console.WriteLine("The file values.txt is not available or it has been removed/renamed. \n{0}", e.Message);
            } 
            catch (Exception e) { //A general exception
                //Providing a more clear description of the error so an Enduser will be able to better understand what went wrong
                //If left to Visual Studio, the error would be very non descriptive for an Enduser
                Console.WriteLine("Something unexpected has occured. Most likely, the file values.txt is not available in the same directory containing this program's .exe. \n{0}", e.Message);
            } 
            finally { 
                //Perform any cleanup to roll back the data or close connections
                //to files, databases, network, etc.
            }

            Console.WriteLine("\nPress any key to close...");
            Console.ReadLine();
        }
    }
}
