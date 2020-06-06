using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSFORMER2.com.decepticon
{
    abstract class transformer
    {
        public abstract void Run();
    }

    class car : transformer
    {
        public override void Run()
        {
            Console.WriteLine("run car");
        }
    }
}
