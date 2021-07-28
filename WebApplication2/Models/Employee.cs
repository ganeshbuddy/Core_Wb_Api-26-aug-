using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Employee
    {
        public int id { get; set; }

        public string emp_name{ get; set; }

        public string gender { get; set; }

        public string dept { get; set; }

        public string salary { get; set; }

        public string mobile { get; set; }

        internal static object FirstOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
