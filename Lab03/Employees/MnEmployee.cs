using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Employees
{
    class MnEmployee
    {
        public static void Main()
        {
            ArrayList employeeArray = new ArrayList();
            for (int i = 0; i < 1; i++)
            {
                Console.Write("Enter firstName : ");
                string fistName = Console.ReadLine();
                Console.Write("Enter LastName : ");
                string lastName = Console.ReadLine();
                Console.Write("Enter Address : ");
                string address = Console.ReadLine();
                Console.Write("Enter sin : ");
                long sin = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter salary : ");
                double salary = Convert.ToDouble(Console.ReadLine());

                csrEmployee employee = new csrEmployee(fistName, lastName, address, sin, salary);
                employeeArray.Add(employee);
            }

            foreach (csrEmployee employee1 in employeeArray)
            {
                Console.Write("Information employee \n" + employee1.ToString());
                Console.Write("Bonus = " + employee1.bonusMoney() + "$ \n");
            }
        }
    }
}
