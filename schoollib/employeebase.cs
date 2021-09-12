using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
   public class EmployeeBase : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual double Salary { get; set; }
    }
}