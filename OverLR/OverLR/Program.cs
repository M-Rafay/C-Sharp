using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OverLR
{
    class fastfood
    {
        public fastfood()
        {
            Console.WriteLine("Fast Foods.");
        }
        public void fastfoodtype()
        {
            Console.WriteLine("Fast Food : Burger wings broast");
        }
    }
    class burger : fastfood
    {
        public int no_of_pattie;
        public int amount;
        public burger()
        {
            Console.WriteLine("Burger");
        }
        public void brand()
        {
            Console.WriteLine("Mccdonalds");
        }
        public void price()
        {
            Console.WriteLine("enter price");
            amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Price is : {0}",amount);
        }
    }


    class pizza : burger
    {
        public pizza()
        {
            Console.WriteLine("making");
        }
        public virtual void making()
        {
            Console.WriteLine("asdf");
        }
    }
    class bigmac : pizza
    {
        public bigmac()
        {
            Console.WriteLine("BigMac");
        }

        /*public override void making()
        {
            Console.WriteLine("big mac burger include");
            Console.WriteLine("");
            Console.WriteLine("");
        }*/
        public override void making()
        {
            
            
            Console.WriteLine("\nBigMac Burger includes");
            Console.WriteLine("Number of Pattie = {0}", no_of_pattie);
            Console.WriteLine("Lattice and Saurce");
        }
        /*class delux : bigmac
        {
            public delux()
            {
                Console.WriteLine("Delux");
            }
            
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            burger bur = new bigmac();
            bur.fastfoodtype();
            bur.no_of_pattie = 2;
            bur.brand();
            //bur.making();
            bur.price();
            Console.ReadKey();
        }
    }
}
