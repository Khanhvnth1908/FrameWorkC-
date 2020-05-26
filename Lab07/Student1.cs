using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07
{
    class Student1
    {
        
        public void DiplayName(String firstName,String lastName)
        {
            Console.WriteLine("The first is {0} The last Name {1} " + firstName, lastName);
        }

        /*static void Main(String[] args)
        {
            Student1 student = new Student1();
            student.DiplayName("Khanh", "Vuong");

            student.DiplayName(firstName: "Henry", lastName: "Parker");

            student.DiplayName("Henry", lastName: "Parker");
        }*/
    }
}
