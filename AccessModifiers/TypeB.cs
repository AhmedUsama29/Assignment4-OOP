using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class TypeB : TypeA
    {

        public int F { get; set; }
        public int G { get; set; }

        public TypeB(int a, int b, int c, int d, int e,int f, int g) :base(a,b,c,d,e)
        {
            F = f;
            G = g;
        }

        override public string ToString()
        {
            return base.ToString() + $"F = {F}, G = {G}";

        }
    }
}
