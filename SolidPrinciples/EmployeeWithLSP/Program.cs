using EmployeeWithLSP.Interface;
using System;
using System.Collections.Generic;

namespace EmployeeWithLSP
{
    /*https://csharp-video-tutorials.blogspot.com/2018/01/open-closed-principle.html
    
    Subtypes must be substitutable for their base type.
    LSP States that IS-A relationship is insufficient and should be replaced with IS-Substitutable with
    IS-Substitutable-For
     
    If S is a subtype of T then objects of type T may be replaced with objects of type S, without breaking
    the program.
    -->Which means, Derived types must be completely substitutable for their base types
    -->This principle is just an extension of the Open Close Principle

    More formally, the Liskov substitution principle (LSP) is a particular definition of a subtyping relation, 
    called (strong) behavioral subtyping.

    Uncle Bob summarized LSP as “Subtypes must be substitutable for their base types”. In other words, 
    given a specific base class, any class that inherits from it, can be a substitute for the base class.
    
    Implementation guidelines : In the process of development we should ensure that 
    1.No new exceptions can be thrown by the subtype unless they are part of the existing exception hierarchy.
    2.We should also ensure that Clients should not know which specific subtype they are calling, nor should they 
    need to know that. The client should behave the same regardless of the subtype instance that it is given.
    3.And New derived classes just extend without replacing the functionality of old classes

    Violation of LSP:
    The classic example of this shows how you cannot substitute a rectangle class for a square class.
    Means if a square class inherits the Rectangle class it is a voilation.

     */
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new PermanentEmployee(1, "John"));
            employees.Add(new TemporaryEmployee(2, "Jason"));
            //Un Comment to see the error
            //employees.Add(new ContractEmployee(3, "Mike"));
            foreach (var employee in employees)
            {
                Console.WriteLine(string.Format("Employee {0} Bonus: {1} MinSalary: {2}",
                employee.ToString(),
                employee.CalculateBonus(100000).ToString(),
                employee.GetMinimumSalary().ToString()));
            }

            Console.WriteLine();

            List<IEmployee> employeesOnly = new List<IEmployee>();

            employeesOnly.Add(new PermanentEmployee(1, "John"));
            employeesOnly.Add(new TemporaryEmployee(2, "Jason"));
            employeesOnly.Add(new ContractEmployee(3, "Mike"));

            foreach (var employee in employeesOnly)
            {
                Console.WriteLine(string.Format("Employee {0}  MinSalary: {1}",
                employee.ToString(),
                employee.GetMinimumSalary().ToString()));
            }
            Console.ReadLine();
        }
    }
}
