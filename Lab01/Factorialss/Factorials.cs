using System;

namespace Factorialss
{
    class Factorials
    {
        static void Main(string[] args)
        {
            int b = 1;
            Console.WriteLine("Input :" );
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a ;i++)
            {
                b = b * i;
            }
            Console.WriteLine(b);
        }
    }
}
