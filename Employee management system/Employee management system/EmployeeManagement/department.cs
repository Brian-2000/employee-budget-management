using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_management_system.EmployeeManagement
{
    class department
    {
        private string deptName;
        private double deptBudget;

        //int[] x = new int[6]
        int counter;
        Employee[] emps = new Employee[6];

        public void AddEmployee(Employee obj)
        {
            emps[counter] = obj;
            counter++;

            if(obj.empGrade > 5)
            {
                this.deptBudget += 150000;
             
            }
            else
            {
                this.deptBudget += 100000;
            }

        }
        public void describe()
        {
            string temp = "Department : " + this.deptName + 
                "\nTotal budget is :" + this.deptBudget + 
                "\nEmployee :";
            
            foreach (Employee t in emps)
            {
                if (t != null)
                {
                    temp += t.ReturnNameGrade() + "";
                }
            }
            Console.WriteLine(temp);
        }

        public department(string depName)
        {
            this.deptName = deptName;
            this.deptBudget = 50000;
        }

    }
}
