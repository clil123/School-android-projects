using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee : Person
    {
        private string seniority;
        private int base_salary;

        public Employee(string first_name, string last_name, string id, string address, string seniority, int base_salary) :
            base(first_name, last_name, id, address)
        {
            this.seniority = seniority;
            this.base_salary = base_salary;
        }

        public override string ToString()
        {
            string result = string.Format("Employee={0}, Seniority = {1}, Base Salary={2}", base.ToString(), this.seniority, this.base_salary);
            return result;
        }
    }
}
