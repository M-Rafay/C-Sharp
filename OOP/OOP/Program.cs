using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.com.studentManagement;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new com.studentManagement.Student();
            std.age = 12;
            std.name = "Rafay" ;
            std.marks = 100;

            std.detail();
            Console.ReadKey();
        }
    }
}
