using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Addition
    {
        public int Add(int num1, int num2)
        {
            return (num1 + num2);
        }
        public int Add(int num1, int num2, int num3)
        {
            return (num1 + num2 + num3);
        }
        public float Add(float num1, float num2)
        {
            return (num1 + num2);
        }
        public string Add(string value1, string value2)
        {
            return (value1 + " " + value2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Addition objProgram = new Addition();
            Console.WriteLine("Add with two int parameter :" + objProgram.Add(3, 2));
            Console.WriteLine("Add with three int parameter :" + objProgram.Add(3, 2, 8));
            Console.WriteLine("Add with two float parameter :" + objProgram.Add(3f, 22f));
            Console.WriteLine("Add with two string parameter :" + objProgram.Add("hello", "world"));
            Console.ReadLine();
        }
    }
}
