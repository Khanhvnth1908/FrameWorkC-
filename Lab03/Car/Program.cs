using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class Program
    {
        public static void Main()
        {
            //declare a car object reference name myCar
            Car myCar;
            //create a Car object, and assign its address to my Car
            System.Console.WriteLine("Creating a Car object and assigning "
                + "it's memory location to myCar");
            myCar = new Car();
            // assign values to the Car object's field using myCar
            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.color = "black";
            myCar.yearBuilt = 1995;

            //display the field values using myCar
            System.Console.WriteLine("My Car details: ");
            System.Console.WriteLine("myCar.make = " + myCar.make);
            System.Console.WriteLine("myCar.model = " + myCar.model);
            System.Console.WriteLine("myCar.color = " + myCar.color);
            System.Console.WriteLine("myCar.yearBuilt = " + myCar.yearBuilt);

            //call the method using myCar
            myCar.Start();
            myCar.Stop();

            //declare another Car object reference and 
            //create another Car object
            System.Console.WriteLine("Create Creating another Car object and" 
                + "assigning its memory location to redPorsche");
            Car redPorche = new Car();
            redPorche.make = "Porche";
            redPorche.model = "Boxster";
            redPorche.color = "red";
            redPorche.yearBuilt = 2000;
            System.Console.WriteLine("redPorche is a " + redPorche.model);

            System.Console.WriteLine("Assigning redPorsche to myCar");
            myCar = redPorche;

            System.Console.WriteLine("My Car details: ");
            System.Console.WriteLine("myCar.make = " + myCar.make);
            System.Console.WriteLine("myCar.model = " + myCar.model);
            System.Console.WriteLine("myCar.color = " + myCar.color);
            System.Console.WriteLine("myCar.yearBuilt = " + myCar.yearBuilt);

            myCar = null;
            Console.ReadLine();
        }
    }
}