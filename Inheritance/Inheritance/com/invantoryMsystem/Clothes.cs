using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.com.invantoryMsystem
{
    class Clothes : Product
    {
        public string Color { get; set; }
        public Clothes(string n):base(n)
        {

        }
    }
}
