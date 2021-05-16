using System;

namespace FactoryDesignPattern
{
    //It is Creational Design Patterns : These patterns deal with the process of objects creation in such a way 
    //that they can be decoupled from their implementing system.
    //This provides more flexibility in deciding which objects need to be created for a given use case/ scenario. 

    //Factory pattern creates object without exposing the creation logic to the client 
    //and refer to newly created object using a common interface

    //Simple factory refers to the newly created object through an interface

    class Program
    {
        //interface can be used in obfuscation
        static void Main(string[] args)
        {
            EmployeeManagerFactory factory = new EmployeeManagerFactory();
            IEmployeeManager employeeManager = factory.GetEmployeeManager(1);

            Employee emp = new Employee();
            emp.Bonus = employeeManager.GetBonus();
            emp.HourlyPay = employeeManager.GetPay();

            Console.WriteLine($"Employee bonus : {emp.Bonus} and hourlyPay : {emp.HourlyPay}");

            Console.ReadLine();
        }
    }
}
