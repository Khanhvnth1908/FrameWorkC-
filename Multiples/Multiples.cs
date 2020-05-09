using System;

namespace Multiples
{
    class Multiples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input :" );
            int a = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i < 10; i++)
            {
                int multiplication = a * i;
                Console.WriteLine(a + " x " + i + " = " + multiplication);
            }
        }
    }
}
