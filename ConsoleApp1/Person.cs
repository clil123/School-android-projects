using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private string first_name;
        private string last_name;
        private string id;
        private string address;

        public Person(string first_name, string last_name, string id, string address)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.id = id;
            this.address = address;
        }

        public override string ToString()
        {
            string result = String.Format("First Name: {0}; Last Name: {1}; id: {2}; address: {3}", first_name, last_name,id,address);
            return result;
        }
    }
}
