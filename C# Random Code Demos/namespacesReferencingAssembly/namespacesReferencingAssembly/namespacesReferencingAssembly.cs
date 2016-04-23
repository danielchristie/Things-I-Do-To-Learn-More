using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabor;

namespace namespacesReferencingAssembly {
    class namespacesReferencingAssembly {
        static void Main(string[] args) {

            //using System.IO.StreamReader()
            //StreamReader myStreamReader = new StreamReader();

            Bob bob = new Bob();
            string html = bob.Lookup("http://www.learnvisualstudio.net");
            Console.WriteLine(html);

            Console.WriteLine("Press any key to close..."); //This keeps the console open until the user presses enter to close
            Console.ReadLine();
        }
    }
}
