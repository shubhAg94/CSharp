using EmployeeWithLSP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWithLSP
{
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee()
        { }

        public PermanentEmployee(int id, string name) : base(id, name)
        { }

        public override decimal CalculateBonus(decimal salary)
        {
            return (salary * .1M);
        }

        public override decimal GetMinimumSalary()
        {
            return 15000;
        }
    }
}
