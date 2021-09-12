using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School;

namespace SchoolSmallSystem
{
    public enum EmployeeType
    {
        Teachers,
        HumanDepartment,
    }
    public  class EmployeeFactory
    {
        public static IEmployee GetEmployeeInstane(EmployeeType EmployType, int id, string name, double salary)
        {
            IEmployee Employee = null;
            switch(EmployType)
            {
                case EmployeeType.Teachers:
                    Employee = new Teachers { Id = id, Name = name, Salary = salary };
                    break;
                case EmployeeType.HumanDepartment:
                    Employee = new HumanDepartment { Id = id, Name = name, Salary = salary };
                    break;
                    default:
                    break;
            }
            return Employee;
        }
    }
}