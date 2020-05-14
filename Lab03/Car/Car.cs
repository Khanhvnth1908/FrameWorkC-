using System;
using System.Diagnostics;
using System.Xml.Schema;

namespace Car
{
    class Car
    {
        //declare the filed
        public string make;
        public string model;
        public string color;
        public int yearBuilt;
        //define the method
        public void Start()
        {
            System.Console.WriteLine(model + "started");
        }
        public void Stop()
        {
            System.Console.WriteLine(model + "stopped");
        }
    }
}
