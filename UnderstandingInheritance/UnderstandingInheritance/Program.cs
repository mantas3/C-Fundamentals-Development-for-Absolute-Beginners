﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "7451i";
            myCar.Color = "Black";
            myCar.Year = 2005;

            Truck myTruck = new Truck();
            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Color = "Black";
            myTruck.Year = 2006;
            myTruck.TowingCapacity = 1200;

            //someMethod(myCar);
            //someMethod(myTruck);

            myCar.PrintMe();
            myTruck.PrintMe();

            Console.ReadLine();

        }

        private static void someMethod(Car car)
        {
            Console.WriteLine("From someMethod: {0}", car.Make);
        }
    }

    abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public abstract void PrintMe();
    }

    class Car : Vehicle
    {


        //public virtual void PrintMe()
        //{
        //    Console.WriteLine("{0} - {1}", this.Make, this.Model);
        //}

        public override void PrintMe()
        {
            Console.WriteLine("{0} - {1}", this.Make, this.Model);
        }

    }

    class Truck : Vehicle
    {
        public int TowingCapacity { get; set; }
        //public override void PrintMe()
        //{
        //    Console.WriteLine("{0} - {1}", this.Make, this.TowingCapacity.ToString());
        //}

        public override void PrintMe()
        {
            Console.WriteLine("{0} - {1}", this.Make, this.TowingCapacity.ToString());
        }

    }

}
