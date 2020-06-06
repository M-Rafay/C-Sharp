using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.com.studentManagement
{
    class Student
    {
        public int age;
        public int marks;
        public string name;

        public void detail()
        {
            Console.WriteLine("Name = {0} Age = {1} Marks = {2}",name,age,marks);
        }
    }
}
