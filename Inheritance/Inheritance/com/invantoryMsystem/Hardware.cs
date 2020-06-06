using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.com.invantoryMsystem
{
    class Hardware:Product
    {

        public Hardware(string n): base(n)
        {
            Console.WriteLine("Hard Ware");
        }
    }
}
