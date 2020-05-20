using System;

namespace Mod2_Lab01
{
    class Employee
    {
        public string employeeName;
        public double employeeSalary;
        private int employeeId;

        public string Name
        {
            get { return employeeName; }
            set { this.employeeName = value; }
        }
        public double BaseSalary
        {
            get { return employeeSalary; }
            set { this.employeeSalary = value; }
        }
        public int Id
        {
            get { return employeeId; }
            set { this.employeeId = value; }
        }

        //constructor
        public Employee(string name,double salary)
        {
            this.employeeName = name;
            this.employeeSalary = salary;
            this.Id = EmployeeCount++;
        } 
             public string getName()
            {
                return this.employeeName;
            }
            public double getSalary()
            {
                return this.employeeSalary;
            }

            public int getId()
            {
                return this.employeeId;
            }

        //Create ineger variable call "EmployeeCount" and assigns value 1
        private static int EmployeeCount = 1;

        //the method return the Employee ID
        public int getEmployeeID()
        {
            return this.Id;
        }

        //the method return employeeId and Name
        public string toString()
        {
            return this.Id + " " + Name;
        }

        //the method return the employee's ID and name and confirm that the employee in the system
        public virtual string employeeStatus()
        {
            return toString() + "is in the company system";
        }
    }
}
