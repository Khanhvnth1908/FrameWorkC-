using System;

namespace Factorials
{
    class Factorials
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a - 1;
            for (int i = a; i!=0 ;i--)
            {
                a = a * b * i;
            }
            Console.WriteLine("a! = " + a);
        }
    }
}
