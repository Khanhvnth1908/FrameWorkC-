using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07
{
    class Calculate
    {
        public static void Addition(int val1,int val2)
        {
            Console.WriteLine(val1 + val2);
        }
        public void Muntiply(int val1,int val2)
        {
            Console.WriteLine(val1 * val2);
        }
    }
    class staticMethods
    {
        /*  static void Main(string[] args)
          {
              Calculate.Addition(10, 50);
              Calculate obj = new Calculate();
              obj.Muntiply(10,20);
          }*/
    }
}
