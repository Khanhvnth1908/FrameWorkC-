using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07
{
    class DemenSion
    {
        double _lenght;
        double _breadth;
        public double Area(double _lenght,double _breadth)
        {
            this._lenght = _lenght;
            this._breadth = _breadth;
            return _lenght * _breadth;
        }
        /*static void Main(string[] args)
        {
            DemenSion obj = new DemenSion();
            Console.WriteLine("Area of rectangle : " + obj.Area(10.5, 12.5));
        }*/
    }
}
