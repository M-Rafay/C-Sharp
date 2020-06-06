using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.com.invantoryMsystem
{
    class Product
    {
        public int ProdID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Product(string name)
        {
            Console.WriteLine("Product");
            this.Name = name;
        }
    }
}
