using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Mod2_Lab02
{
    class TechnicalEmployee : Employee
    {
        public double successfulCheckIn = 5;


        public TechnicalEmployee(string name) : base(name, 75000)
        {
            
        }

        public override string employeeStatus()
        {
            return this.toString() + " has " + this.successfulCheckIn + "success full Check In";
        }

    }
}
