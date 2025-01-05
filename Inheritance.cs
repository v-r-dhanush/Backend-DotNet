using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTask
{
    public class Inheritance
    {
        public string[] person = { "Juan", "Sara", "Carlos" };

        public class Person
        {
            public string Name;
            public Person(string name)
            {
                this.Name = name;
            }
        }
        public class Student : Person
        {
            public Student(string name) : base(name)
            {
                this.Name = "Study";
                Console.WriteLine(Name);
            }
        }

        public class Teacher : Person
        {
            public Teacher(string name) : base(name)
            {
                this.Name = "Explain";
                Console.WriteLine(Name);
            }
        }
    }
}