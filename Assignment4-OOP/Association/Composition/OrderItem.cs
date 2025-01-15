using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_OOP.Association.Composition
{
    //Association Realationship [Composition]
    internal class OrderItem
    {
        public int id { get; set; }

        public required Product Product { get; set; }

        //public OrderItem(Product product)
        //{
        //    Product = product;
        //}
    }
}
