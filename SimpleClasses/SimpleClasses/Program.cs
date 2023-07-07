using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();

            //Car myNewCar = new Car("Ford", 2010, 20000);

            
            Console.WriteLine(myNewCar.Make);


            MyClass.MyMethod();


            myNewCar.Make = "Toyota";
            myNewCar.Model = "4Runner";
            myNewCar.Year = 2006;
            myNewCar.OriginalPrice = 35000;
            myNewCar.Color = "White";

            //Car myOtherCar = myNewCar;

            //Console.WriteLine(myOtherCar.Make);

            //myOtherCar = null;
            //myNewCar = null;

            //Console.WriteLine("{0} - {1} - {2}", myNewCar.Make, myNewCar.Model, myNewCar.Color);

            //double myValue = myNewCar.DetermineMarketValue();
            //Console.WriteLine(myCarValue);            

            //Console.WriteLine(myNewCar.CurrentValue().ToString());


            //Console.WriteLine("Before: " + myNewCar.Make);
            //doByValue(myNewCar);
            //Console.WriteLine("After By Value: " + myNewCar.Make);
            //doByReference(ref myNewCar);
            //Console.WriteLine("After By Reference: " + myNewCar.Make);

            Console.ReadLine();

        }

        
        private static double determineMarketValue(Car car)
        {
            double carValue = (((double)DateTime.Now.Year - (double)car.Year) / 10) * car.OriginalPrice;
            return carValue;
        }

        private static void doByValue(Car car)
        {
            car = new Car();
            car.Make = "BMW";
        }

        private static void doByReference(ref Car car)
        {
            car = new Car();
            car.Make = "BMW";
        }


    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double OriginalPrice { get; set; }

        public Car()
        {
            //this.Make = "Nissan";
        }

        public Car(string name, int year, double amount)
        {
            this.Make = name;
            this.Year = year;
            this.OriginalPrice = amount;
        }

        public Car(string color, int year)
        {
           // this.Make = name;
            this.Year = year;
          //  this.OriginalPrice = amount;
        }

        public double DetermineMarketValue()
        {
            return 0.0;
        }

        public double CurrentValue()
        {
            return 0.0;
        }
    }

    public class MyClass
    {
        public static void MyMethod() { }
    }
}
