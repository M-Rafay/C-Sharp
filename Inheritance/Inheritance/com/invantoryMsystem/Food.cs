using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.com.invantoryMsystem
{
    class Food : Product
    {
        public DateTime Exp { get; set; }
        public Food(string n) : base(n)
        {

        }
    }

    
}
