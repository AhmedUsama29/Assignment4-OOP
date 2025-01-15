using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_OOP.Association.Composition
{
    internal class Order
    {

        public int id { get; set; }
        public required string UserEmail { get; set; }

        public decimal OrderTotal { get; set; }

        public required List<OrderItem> OrderItems { get; set; }
        //                             ?

    }
}
