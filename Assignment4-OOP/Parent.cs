using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_OOP
{
    internal class Parent
    {
        public Parent(int x, int y) //parameterized constructor
        {
            X = x;
            Y = y;
        }

        //public Parent() //parameterless constructor
        //{
            
        //}

        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }

        public virtual int Product()
        {
            return X * Y;
        }
    }
}
