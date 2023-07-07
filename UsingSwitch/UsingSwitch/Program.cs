using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in hero's name to see his nickname: ");
            string userValue = Console.ReadLine();

            switch (userValue)
            {
                case "Batman":
                    Console.WriteLine("Caped crusaded");
                    break;
                case "Superman":
                    Console.WriteLine("Man of Steel");
                    break;
                case "Green Lantern":
                    Console.WriteLine("Emerald Knight");
                    break;
                default:
                    Console.WriteLine("Does not compute");
                    break;
            }

            Console.ReadLine();

        }
    }
}
