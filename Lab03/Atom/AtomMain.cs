using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Atom
{
    class AtomMain
    {

        static void Main(string[] args)
        {
            Console.Write("Nhập số nguyên tố muốn thêm: ");
            int n = Convert.ToInt32(Console.ReadLine());
            ArrayList atomArray = new ArrayList();
            Console.WriteLine("Atomic Information");
            Console.WriteLine("===================\n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter atomic number:");
                int atomicNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter symbol:");
                string symbol = Console.ReadLine();
                Console.WriteLine("Enter full name:");
                string fullName = Console.ReadLine();
                Console.WriteLine("Enter atomic weight");
                double weight = Convert.ToDouble(Console.ReadLine());

                Atom atom = new Atom(atomicNumber, symbol, fullName, weight);
                atomArray.Add(atom);
            }



            foreach (Atom atom1 in atomArray)
            {
                Console.WriteLine(atom1.ToString());
            }

        }
    }
}
