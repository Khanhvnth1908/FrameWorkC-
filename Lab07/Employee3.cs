using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07
{
    class Employee3
    {
        private int _emId;
        private int _age;
        private string _empName;
        private double _salary;
        Employee3(int id,int age,string name,double salary)
        {
            Console.WriteLine("Constructor for Employee called");
            _emId = id;
            _empName = name;
            _age = age;
            _salary = salary;
        }
        Employee3()
        {
            Console.WriteLine("Destructor for EMployee called");
        }
        static void Main(string[] args)
        {
            Employee3 employee = new Employee3(1,35,"jone",5000);
            Console.WriteLine("EMployee Id : " + employee._emId);
            Console.WriteLine("EMployee age : " + employee._age);
            Console.WriteLine("EMployee Name : " + employee._empName);
            Console.WriteLine("EMployee salary : " + employee._salary);
        }
    }
}
