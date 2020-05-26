using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07
{
    public class Rectangle
    {
        double _lenght;
        double _breaded;
        public Rectangle()
        {
            _lenght = 13.5;
            _breaded = 20.5;

        }
        public Rectangle(double _lenght,double _breaded)
        {
            this._lenght = _lenght;
            this._breaded = _breaded;
        }
        public double getArea()
        {
            return _lenght * _breaded;
        }
        /* static void Main(string[] args)
         {
             Rectangle obj = new Rectangle();
             Console.WriteLine("Area of Rectangle " + obj.getArea());

             Rectangle obj1 = new Rectangle(2.5, 6.9);
             Console.WriteLine("Area of Rectangle " + obj1.getArea());
         }*/
    }
}
