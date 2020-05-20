using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2_Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee("Libby", 75000);

            var employee2 = new TechnicalEmployee("Zayyah");

            var employee3 = new BusinessEmployee("winter");


            Console.WriteLine(employee1.employeeStatus() + " \n" + employee2.employeeStatus() + " \n" + employee3.employeeStatus());
        }

    }
}
