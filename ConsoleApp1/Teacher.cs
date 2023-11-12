using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Teacher : Person
    {
        private string profession;
        private int salary;

        public Teacher(string first_name, string last_name, string id, string address, string profession, int salary) :
            base(first_name, last_name, id, address)
        {
            this.profession = profession;
            this.salary = salary;
        }

        public override string ToString()
        {
            string result = string.Format("Teacher={0}, profession = {1}, salary={2}", base.ToString(), this.profession, this.salary);
            return result;
        }
    }
}
