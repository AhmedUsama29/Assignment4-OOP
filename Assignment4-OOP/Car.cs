using AccessModifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_OOP
{
    internal class Car : TypeA
    {

        #region Attributes
        public string Model { get; set; }

        public int Year { get; set; }
        public int Speed { get; set; }
        #endregion


        #region Constructor
        public Car(int a, int b, int c, int d, int e, string model, int year, int speed) : base(a, b, c, d, e)
        {

            Model = model;
            Year = year;
            Speed = speed;
        }

        #endregion


        public override string ToString()
        {
            return base.ToString() + $"Model = {Model}, Year = {Year}, Speed = {Speed}";
        }
    }
}
