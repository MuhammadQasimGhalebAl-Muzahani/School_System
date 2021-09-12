using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School;

namespace SchoolSmallSystem
{
    public class Teachers : EmployeeBase
    {
        public override double Salary
        {
            get { return base.Salary + 10; }
        }
    }
}