using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_OOP
{
    internal class Complex
    {

        public int Real { get; set; }

        public int Imaginary { get; set; }

        override public string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }

        //OverLoading operator : Non-Private Class member function

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c = new Complex();
            c.Real = (c1?.Real ?? 0) + (c2?.Real ?? 0);
            c.Imaginary = (c1?.Imaginary ?? 0) + (c2?.Imaginary ?? 0);  
            return c;
        }

        public static Complex operator +(Complex c1, int right)
        {
            Complex c = new Complex();
            c.Real = (c1?.Real ?? 0) + right;
            c.Imaginary = (c1?.Imaginary ?? 0) + right;
            return c;
        }
        public static Complex operator +(int left, Complex c2)
        {
            Complex c = new Complex();
            c.Real = left + (c2?.Real ?? 0);
            c.Imaginary = left + (c2?.Imaginary ?? 0);
            return c;
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex c = new Complex();
            c.Real = (c1?.Real ?? 0) - (c2?.Real ?? 0);
            c.Imaginary = (c1?.Imaginary ?? 0) - (c2?.Imaginary ?? 0);
            return c;
        }

        //unary operator

        public static Complex operator ++(Complex c1)
        {
            Complex c = new Complex();
            c.Real = (c1?.Real ?? 0) + 1;
            c.Imaginary = c1.Imaginary;
            return c;
        }
        public static Complex operator --(Complex c1)
        {
            Complex c = new Complex();
            c.Real = (c1?.Real ?? 0) - 1;
            c.Imaginary = c1.Imaginary;
            return c;
        }

        // < > <= >= == !=

        public static bool operator >(Complex c1, Complex c2)
        {
            if(c1?.Real == c2?.Real)
                return c1?.Imaginary > c2?.Imaginary;
            else return c1?.Real > c2?.Real;
        }

        public static bool operator <(Complex c1, Complex c2)
        {
            if (c1?.Real == c2?.Real)
                return c1?.Imaginary < c2?.Imaginary;
            else return c1?.Real < c2?.Real;
        }


    }
}
