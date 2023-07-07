using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myValue = superSecretFormula();

            string myValue = superSecretFormula("Bob");
            
            Console.WriteLine(myValue);         

            Console.WriteLine(superSecretFormula());

            Console.ReadLine();
        }

        private static string superSecretFormula()
        {
            return "Hello world";
        }

        private static string superSecretFormula(string name)
        {
            return String.Format("Hello World, {0}", name);
        }
    }
}
