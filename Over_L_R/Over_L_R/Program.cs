using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Over_L_R
{
    class fastfood
    {
        public fastfood()
        {
            Console.WriteLine("fast food");
        }
        public void fastfoodtype()
        {
            Console.WriteLine("fast food:\n burger\n wings\n broast");
        }
    }

    class Burger : fastfood
    {
        public int no_of_pattie;
        public int amount;

        public Burger()
        {
            Console.WriteLine("BURGER");
        }

        public void Brand()
        {
            Console.WriteLine("McDonald");
        }

        public void Price()
        {
            Console.WriteLine("Enter price:");
            amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Price is :{0}",amount);
        }
        public virtual void making()
        {
            Console.WriteLine("Burger Making");
        }
    }

    

    class Bigmac : Burger
    {
        public Bigmac()
        {
            Console.WriteLine("Bigmac");
        }

        public override void making()
        {
            Console.WriteLine("bigmac burger include");
            Console.WriteLine("no of pattie = {0}",no_of_pattie);
            Console.WriteLine("lattice and sauce");
        }
    }

    class fishburger : Burger
    {
        public fishburger()
        {
            Console.WriteLine("Making");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Burger burg = new Burger();
            burg.making();

            /*over riding*/

            Console.WriteLine("\n over riding \n");

            Burger bur = new Bigmac();
            bur.fastfoodtype();
            bur.no_of_pattie = 2;
            bur.Brand();
            bur.making();
            bur.Price();
           
            Console.ReadKey();
        }
    }
}
