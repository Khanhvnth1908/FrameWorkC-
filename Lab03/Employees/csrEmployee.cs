using System;

namespace Employees
{
    class csrEmployee
    {
        protected string fistName;
        protected string lastName;
        protected string address;
        protected long sin;
        protected double salary;
        public csrEmployee(string fistName, string lastName, string address, long sin, double salary)
        {
            this.fistName = fistName;
            this.lastName = lastName;
            this.address = address;
            this.sin = sin;
            this.salary = salary;
        }

        public override string ToString()
        {
            return "\n" + "fistName : " + fistName + "\n" +
                "lastName : " + lastName + "\n" +
                "Address : " + address + "\n" +
                "sin : " + sin + "\n" +
                "salary : " + salary + "$" + "\n";
        }

        public double bonusMoney()
        {
            return salary = salary * 0.4;
        }
    }
}
