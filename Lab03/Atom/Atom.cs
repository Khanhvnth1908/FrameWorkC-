using System;

namespace Atom
{
    class Atom
    {
        protected int atomicNumber;
        protected string symbol;
        protected string fullName;
        protected double weight;

        public Atom(int atomicNumber, string symbol,string fullName,double weight)
        {
            this.atomicNumber = atomicNumber;
            this.symbol = symbol;
            this.fullName = fullName;
            this.weight = weight;

        }


        public override string ToString()
        {
            return  atomicNumber + " " + symbol + " " + fullName + " " + weight;
        }


    }
}
