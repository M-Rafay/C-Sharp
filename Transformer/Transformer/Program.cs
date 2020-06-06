 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transformer.com.decepticon;

namespace Transformer
{
    class Program
    {
        static void Main(string[] args)
        {
            Transformers trans = new Car();
            trans.Run();
            Console.ReadKey();

        }
    }
}
