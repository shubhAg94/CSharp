using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWithLSP.Interface
{
    interface IEmployeeBonus
    {
        decimal CalculateBonus(decimal salary);
    }
}
