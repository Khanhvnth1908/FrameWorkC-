using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07
{
    static class Products
    {
        static int _productID;
        static double _price;
        static Products()
        {
            _productID = 10;
            _price = 156.32;
        }

        public static void Display()
        {
            Console.WriteLine("ProductId " + _productID);
            Console.WriteLine("product price " + _price);
        }

    }

    class Medicine
    {
        /* static void Main(string[] args)
         {
             Products.Display();
         }*/
    }
}
