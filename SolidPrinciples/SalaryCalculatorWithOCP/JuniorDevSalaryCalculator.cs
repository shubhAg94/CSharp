using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculatorWithOCP
{
    public class JuniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public JuniorDevSalaryCalculator(DeveloperReport developerReport) : base(developerReport)
        {
        }

        public override double CalculateSalary() => DeveloperReport.HourlyRate * DeveloperReport.WorkingHours;
    }
}
