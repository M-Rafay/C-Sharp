using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.com.invantoryMsystem;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Clothes cloth = new com.invantoryMsystem.Clothes("A");
            cloth.Name = "Jeans";
            cloth.Price = 1000;
            cloth.Color = "ad";
            cloth.ProdID = 1;
            Console.WriteLine(cloth.color);

            Furniture fur = new Furniture("B");
            fur.ProdID = 2;
            fur.Name = "wood";
            fur.Price = 5000;
            fur.WoodType = "cessum";
            
            Hardware hd = new Hardware("Hammer");
            Console.ReadKey();
        }
    }
}
