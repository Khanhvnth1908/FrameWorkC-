using System;

namespace Maximum
{
    class Maximum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input b :");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input c :");
            int c = Convert.ToInt32(Console.ReadLine());

            int max = a;
            if(a > b && a > c)
            {
                Console.WriteLine("Max = " + a);
            }else if(b > a && b > c)
            {
                Console.WriteLine("Max = " + b);
            }
            else
            {
                Console.WriteLine("Max = " + c);
            }

        }
    }
}
