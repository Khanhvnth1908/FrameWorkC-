using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07
{
    class Employees
    {
        string _empName;
        int _empAge;
        string _depName;

        Employees(string name,int num)
        {
            _empName = name;
            _empAge = num;
            _depName = "Research & Development";
        }
        /*static void Main(string[] args)
        {
            Employees employees = new Employees("John",10);
            Console.WriteLine(employees._depName);
        }*/
    }
}
