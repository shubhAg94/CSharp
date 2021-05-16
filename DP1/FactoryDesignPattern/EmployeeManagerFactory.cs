namespace FactoryDesignPattern
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int employeeTypeId)
        {
            IEmployeeManager employeeManager = null;
            if (employeeTypeId == 1)
            {
                employeeManager = new PermanentEmployeeManager();
            }
            else if (employeeTypeId == 2)
            {
                employeeManager = new ContractEmployeeManager();
            }
            return employeeManager;
        }
    }
}
