using System;

namespace EmployeeBonusCalWithoutOCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empJohn = new Employee(1, "John", "Permanent");
            Employee empJason = new Employee(2, "Jason", "Temp");

            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",empJohn.ToString(),empJohn.CalculateBonus(100000).ToString()));
            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",empJason.ToString(),empJason.CalculateBonus(150000).ToString()));
            Console.ReadLine();
        }
    }
}
