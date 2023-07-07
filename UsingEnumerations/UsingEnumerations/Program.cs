using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingEnumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            //Superhero myValue = Superhero.Batman;
            //Console.WriteLine("Hello world!");

            Console.WriteLine("Type in super hero's name to see his nickname:");
            string userValue = Console.ReadLine();
            Superhero myValue;

            if (Enum.TryParse<Superhero>(userValue, true, out myValue))
            {
                switch (myValue)
                {
                    case Superhero.Batman:
                        Console.WriteLine("Caped crusader");
                        break;
                    case Superhero.Superman:
                        Console.WriteLine("Man of steel");
                        break;
                    case Superhero.GreenLantern:
                        Console.WriteLine("Emerald knight");
                        break;
                    default:
                        Console.WriteLine("Does not compute");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Does not compute");
            }




            Console.ReadLine();


        }

        enum Superhero
        {
            Batman,
            Superman,
            GreenLantern
        }
    }
}
