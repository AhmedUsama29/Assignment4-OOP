using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_OOP.Association.Composition
{
    internal class Product
    {
        public int id { get; set; }

        public required string Name { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitOFStock { get; set; }
    }
}
