﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_OOP.Association.Aggregration
{
    internal class Employee
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public decimal Salary { get; set; }
    }
}
