using System;

namespace Mod2_Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            var emlpoyee1 = new TechnicalEmployee("Billy");
            var employee2 = new BusinessEmployee("Chese");

            Console.WriteLine(emlpoyee1.employeeStatus() + "\n " + employee2.employeeStatus() );
        }
    }
}
