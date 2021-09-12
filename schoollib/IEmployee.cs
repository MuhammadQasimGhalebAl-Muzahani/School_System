using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
  public  interface IEmployee
    {
        int Id { get; set; }
        string Name { get; set; }
        double Salary { get; set; }
    }
}