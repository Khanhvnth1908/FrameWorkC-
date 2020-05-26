using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07
{
    class OutParameters
    {
        static void Depreciantion(out int val)
        {
            val = 20000;
            int dep = val * 5 / 100;
            int atm = val - dep;
            Console.WriteLine("Depreciation Amount: " + dep);
            Console.WriteLine("Reduced value after depreciation: " + atm);           
        }
        /*static void Main(string[] args)
        {
            int value;
            Depreciantion(out value);
        }*/
    }
}
