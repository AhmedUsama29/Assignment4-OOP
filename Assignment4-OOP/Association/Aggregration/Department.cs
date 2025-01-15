using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_OOP.Association.Aggregration
{

    //Association Relation Ship [Aggregation] :
    //If No Employees The Department Exist Normally
    internal class Department
    {
        public int Code { get; set; }

        public required string name { get; set; }

        public List<Employee>? Employees { get; set; }
    }
}
