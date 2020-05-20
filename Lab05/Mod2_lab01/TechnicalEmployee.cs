using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2_Lab01
{
    class TechnicalEmployee : Employee
    {
        public TechnicalEmployee(string name) : base(name, 75000)
        {
            
        }

        public int susccessfulCheckIn = 5;

        public override string employeeStatus()
        {
            return this.toString() + " has " + this.susccessfulCheckIn + " successful Check In ";
        }

    }
}
