using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07
{
    class OptionalParameterExample
    {
         void printMessage(string message ="Hello User")
        {
            Console.WriteLine("{0}", message);
        }
        /*static void Main(string[] args)
        {
            OptionalParameterExample optional = new OptionalParameterExample();
            Console.WriteLine("Welcome Users");
            optional.printMessage();
        }*/
    }
}
