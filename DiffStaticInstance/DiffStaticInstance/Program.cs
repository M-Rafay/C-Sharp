using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffStaticInstance
{
    public class verify
    {
        public verify()
        {
            InstanceConstructor++;

            Console.WriteLine("Instance Constructor #{0} Called.", InstanceConstructor);
        }
        public static int InstanceConstructor = 0;

        static verify()
        {
            Console.WriteLine("Static Constructor.");
        }

        
    }


    class Program
    {
        static void Main(string[] args)
        {
            verify One = new verify();
            verify Two = new verify();
            Console.ReadKey();
        }

        
    }

}
