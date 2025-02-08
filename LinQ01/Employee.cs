using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ01
{
    internal class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }




        override public string ToString()
        {
            return $"ID: {id} Name: {Name} Salary: {Salary}";
        }
    }
}
