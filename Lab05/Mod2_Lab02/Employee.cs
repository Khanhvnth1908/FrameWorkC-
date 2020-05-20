using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Mod2_Lab02
{
    abstract class Employee
    {
        //Create integer variable called "employeeCount" and assign value to 1
        private static int employeeCount = 1;

        //3 private member variable: employeeName,employeeSalary,employeeID
        private string employeeName;
        private double employeeSalary;
        private int employeeID;

        public string Name
        {
            get { return employeeName; }
            set { this.employeeName = value; }
        }

        public double Salary
        {
            get { return employeeSalary; }
            set { this.employeeSalary = value; }
        }

        public int ID
        {
            get { return employeeID; }
            set { this.employeeID = value; }
        }
        public Employee(string name,double salary)
        {
            this.employeeName = name;
            this.employeeSalary = salary;
            this.employeeID = employeeCount++;
        }
        public string getName()
        {
            return this.Name;
        }
        public double getSalary()
        {
            return this.Salary;
        }

        public int getID()
        {
            return this.ID;
        }

        public string toString()
        {
            return this.ID + " " + Name;
        }

        public abstract string employeeStatus();
    }
}
