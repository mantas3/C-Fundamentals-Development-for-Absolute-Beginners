using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";
            */
              
            /*
            //ArrayLists are dinamically sized  and suppor other cool features like sorting, removing items, etc.
            System.Collections.ArrayList myArrayList = new System.Collections.ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);
            myArrayList.Remove(b1);

            //However everything is stored as an Object ... whichi introduces potencial problems;
            foreach (object o in myArrayList)
            {
                Console.WriteLine(((Car)o).Make);
            }
            */

            /*
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(b1);

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Make);
            }
            */

            /*
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.Make, car1);
            myDictionary.Add(car2.Make, car2);

            Console.Write(myDictionary["Geo"].Model);
            */

            //string[] names = {"Bob", "John", "Malcolm", "Mantas" };

            //Car car1 = new Car() { Make = "BMW", Model = "350" };
            //Car car2 = new Car() { Make = "Audi", Model = "100" };
            //Car car3 = new Car() { Make = "Nissan", Model = "Pathfinder" };

            //Collection initializers

            List<Car> myList = new List<Car>()
            {
                new Car(){Make = "Audi", Model = "100"},
                new Car(){Make = "BMW", Model = "350"},
                new Car(){Make = "Nissan", Model = "Pathfinder"}
            };

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }


    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }

}
