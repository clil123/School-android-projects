using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person p1 = new Person("aaa", "bbb", "1","asdg");
            Console.WriteLine(p1);
            string[] arr = new string[3];
            arr[0] = "1";
            arr[1] = "2";
            arr[2] = "3";

            Student s1 = new Student("a1", "b1", "2", "wwwwrr", arr, 11);
            Console.WriteLine(s1);

            Teacher t1 = new Teacher("a2", "b2", "2", "wwfgwwrr", "software engineer", 22);
            Console.WriteLine(t1);

            Employee e1 = new Employee("a3", "b3", "3", "wwfgwwrr", "cook", 33);
            Console.WriteLine(e1);
            Console.ReadKey();
        }
    }
}