using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2_Lab01
{
    class BusinessEmployee : Employee
    {
        public BusinessEmployee(string name) : base(name, 5000)
        {

        }

        //create double variable called "bonusBudget" and assigns values to 1000

        public double bonusBudget = 1000;

        //this method return the toString() method-which is employee's Id number and Name - and print the bonus budget

        public override string employeeStatus()
        {
            return this.toString() + " with a budget of " + this.bonusBudget; 
        }
    }
}
