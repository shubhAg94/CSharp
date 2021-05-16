using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWithoutLSP
{
    public class ContractEmployee : Employee
    {
        public ContractEmployee()
        { }   

        public ContractEmployee(int id, string name) : base(id, name)
        { }

        //Contract employee is not eligible for any bonus, Hence We are throwing the bonus
        //LSP Violation: Because it is throwing new exception(No new exceptions can be thrown by the subtype)
        public override decimal CalculateBonus(decimal salary)
        {
            throw new NotImplementedException();
        }
    }
}
