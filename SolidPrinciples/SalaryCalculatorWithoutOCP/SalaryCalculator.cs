using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculatorWithoutOCP
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<DeveloperReport> _developerReports;

        public SalaryCalculator(List<DeveloperReport> developerReports)
        {
            _developerReports = developerReports;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;

            foreach (var devReport in _developerReports)
            {
                if (devReport.Level == "Senior developer")
                {
                    totalSalaries += devReport.HourlyRate * devReport.WorkingHours * 1.2;
                }
                else
                {
                    totalSalaries += devReport.HourlyRate * devReport.WorkingHours;
                }
            }
            return totalSalaries;
        }
    }
}
