using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Mod2_Lab02
{
    class BusinessEmployee : Employee
    {
        public double bonusBudget = 1000;

        public BusinessEmployee(string name) : base(name, 5000)
        {

        }

        public override string employeeStatus()
        {
            return toString() + " with a budget of " + this.bonusBudget; 
        }
    }
}
