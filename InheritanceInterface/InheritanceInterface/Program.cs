using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInterface
{

    interface IA
    {
        void AMethod();
    }
    class A:IA
    {
        public void AMethod()
        {
            Console.WriteLine("A");
        }
    }

    interface IB
    {
        void BMethod();
    }
    class B:IB

    {
        public void BMethod()
        {
            Console.WriteLine("B");
        }
    }

    class AB : IA,IB
    {
        //A a = new A();
        //B b = new B();

        public void AMethod()
        {
            Console.WriteLine("AB IA");
        }

        public void BMethod()
        {
            Console.WriteLine("AB IB");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            AB ab = new AB();
            ab.AMethod();
            ab.BMethod();
            Console.ReadKey();
        }
    }
}
