using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverrideExample
{
    class BC
    {
        public virtual void Display()
        {
            System.Console.WriteLine("Invoking the function Display() of Base class BC");
        }
    }

    class DC : BC // Here we instantiate a derived class DC of the base class BC
    {
        public override void Display() // Here we are telling C# that we will be overriding Display() of the base BC class's Display()
        {
            System.Console.WriteLine("Overriding the function Display() of Base class BC and invoking the function Display() of the Derived class DC");
        }
    }

    class TC : DC   // Here we instantiate a derived class TC of the base class DC
    {
        public override void Display()  // Here we are telling C# that we will be overriding Display() of the base DC class's Display()
        {
            System.Console.WriteLine("Overriding the function Display() of Base class DC and invoking the function Display() of the Derived class TC");
        }
    }

    class Demo
    {
        public static void Main()
        {
            BC b;           // Instructing C# to associate the BC class with an object named b
            b = new BC();   // Instanciating object b to reference the BC Class
            b.Display();    // Calling on the function Display() of Base class BC

            b = new DC();   // Instanciating an object b to reference the DC Class
            b.Display();    // Calling on the function Display() of Derived class DC

            b = new TC();   // Instanciating an object b to reference the TC Class
            b.Display();    // Calling on the function Display() of Derived class TC

            Console.WriteLine("Press enter to close..."); //This keeps the console open until the user presses enter to close
            Console.ReadLine();
        }
    }
}