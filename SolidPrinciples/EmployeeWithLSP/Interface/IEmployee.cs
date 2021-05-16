using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWithLSP.Interface
{
    interface IEmployee
    {
        int ID { get; set; }
        string Name { get; set; }
        decimal GetMinimumSalary();
    }
}
