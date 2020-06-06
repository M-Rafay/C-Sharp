using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.com.invantoryMsystem
{
    class Furniture : Product
    {
        public string WoodType { get; set; }

        public Furniture(string n):base(n)
        {

        }
    }
}
