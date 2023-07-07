using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabor;

namespace NamespacesAndReferencingAssenmblies
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.IO.StreamReader myStreamReader = new System.IO.StreamReader();
            
            //StreamReader myStreamReader = new StreamReader();

            Bob myBob = new Bob();
            Console.WriteLine(myBob.Lookup("http://xz.xz.lt"));
            Console.ReadLine();
        }
    }
}
