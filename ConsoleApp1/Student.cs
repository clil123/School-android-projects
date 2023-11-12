using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student : Person
    {
        private string[] courses;
        private int year;

        public Student(string first_name, string last_name, string id, string address, string[] courses, int year) :
            base(first_name, last_name, id, address)
        {
            this.courses = new string[courses.Length];
            for (int i = 0; i < courses.Length; i++)
            {
                this.courses[i] = courses[i];
            }
            this.year = year;
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < this.courses.Length; i++)
                str += this.courses[i] + ", ";
            string result = string.Format("Student={0}, courses = {1}, years={2}", base.ToString(), this.courses, this.year);
            return result;
        }
    }
}
