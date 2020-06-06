using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class Base
    {
        public virtual int Add(int num1, int num2)
        {
            return (num1 + num2);
        }
    }
    class Child : Base
    {
        public override int Add(int num1, int num2)
        {
            if (num1 <= 0 || num2 <= 0)
            {
                Console.WriteLine("Values could not be less than zero or equals to zero");
                Console.WriteLine("Enter First value : ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter First value : ");
                num2 = int.Parse(Console.ReadLine());

            }
            return (num1 + num2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base baseObj;
            baseObj = new Base();
            Console.WriteLine("Base class method Add :" + baseObj.Add(-3, 8));
            baseObj = new Child();
            Console.WriteLine("Child class method Add :" + baseObj.Add(-2 , 2));
            Console.ReadLine();
        }
    }
}
