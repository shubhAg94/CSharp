using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeBonusCalWithoutOCP
{
    public class Employee
    {
        public int ID { get; set; }
        public string EmployeeType { get; set; }
        public string Name { get; set; }

        Employee()
        {

        }
        public Employee(int id, string name, string type)
        {
            this.ID = id;
            this.Name = name;
            this.EmployeeType = type;
        }

        public decimal CalculateBonus(decimal salary)
        {
            decimal saalry;
            if (this.EmployeeType == "Permanent")
                salary = salary * .1M;
            else if(this.EmployeeType == "Temporary")
                salary = salary * .05M;
            return salary;
        }
    }
}
