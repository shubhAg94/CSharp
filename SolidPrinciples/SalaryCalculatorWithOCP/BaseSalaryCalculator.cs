using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculatorWithOCP
{
    //https://code-maze.com/open-closed-principle/
    public abstract class BaseSalaryCalculator
    {
        protected DeveloperReport DeveloperReport { get; private set; }

        public BaseSalaryCalculator(DeveloperReport developerReport)
        {
            DeveloperReport = developerReport;
        }

        public abstract double CalculateSalary();
    }
}
