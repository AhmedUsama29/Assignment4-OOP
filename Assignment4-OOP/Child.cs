using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_OOP
{
    internal class Child : Parent
    {

        //public int X { get; set; }  // Dublicated property
        //public int Y { get; set; }  // Dublicated property

        //if we have inheretiance ==> The child class constructor by default chain 
        //on parent class parameterless constructor
        public int Z { get; set; } //New property

        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        override public string ToString()
        {
            return base.ToString() + $", Z: {Z}";
        }

        override public int Product()     // or use keyword (new)
        {
            return base.Product() * Z;

        }

    }
}
