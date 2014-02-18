using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolForVersionControl4
{
    class Student
    {
        public String Name { get; set; }
        public int age { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            this.age = age;
        }
    }
}
