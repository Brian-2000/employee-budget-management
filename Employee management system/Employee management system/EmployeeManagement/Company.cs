using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_management_system.EmployeeManagement
{
    class Company
    {
        static void Main()

        {
            Employee brian = new Employee("Brian Muchere", 8);
            Employee joan = new Employee("Joan Nanzala", 6);
            Employee daniel = new Employee("Daniel Kiptoo", 7);
            Employee bill = new Employee("Bill Andani", 4);
            Employee lydia = new Employee("Lydia Kerubo", 7);
            Employee susan = new Employee("Susan Wanjiru", 6);

            department sales = new department("Company Sales");

            sales.AddEmployee(bill);
            sales.AddEmployee(joan);
            sales.AddEmployee(daniel);
            sales.describe();

            department IT = new department("Company IT");
            IT.AddEmployee(brian);
            IT.AddEmployee(lydia);
            IT.AddEmployee(susan);
            IT.describe();

        }
    }
}
