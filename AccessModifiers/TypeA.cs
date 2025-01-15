using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class TypeA
    {
        public TypeA(int a, int b, int c, int d, int e)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            E = e;
        }

        public TypeC TypeC { get; set; } // 1-1
        public List<TypeC> TypeCs { get; set; } // 1 - M

        public int A { get; set; } //public (no inheretance) 

        private int B { get; set; } // private (no inheretance)

        protected int C { get; set; } //private (no inheretance)
        private protected int D { get; set; } // private (no inheretance)
        protected internal int E { get; set; } // internal (no inheretance)


        public override string ToString()
        {
            return $"A = {A}, B = {B}, C = {C}, D = {D}, E = {E},";
        }

    }
}
