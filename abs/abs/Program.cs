using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abs
{
    public abstract class Phone
    {
        public abstract void call();
        public abstract void camera();
        public abstract void music();
    }

    public class repair
    {
        public repair()
        {
            Console.WriteLine("\t\tPHONE REPAIR SHOP");

        }
        public void Phone_repair(Phone p)
        {
            
            p.call();
            p.camera();
            p.music();
        }
    }
    
    class samsung_phone:Phone
    {
        public override void call()
        {
            Console.WriteLine("SAMSUNG PHONE");
            Console.WriteLine("\tcall");
        }

        public override void camera()
        {
            Console.WriteLine("\tcamera");

        }
        public override void music()
        {
            Console.WriteLine("\tmusic");
            Console.WriteLine("Repairing...");
            Console.WriteLine("\n");

        }
    }
    class oppo_phone : Phone
    {
        public override void call()
        {
            Console.WriteLine("OPPO PHONE");
            Console.WriteLine("\tcall");
        }

        public override void camera()
        {
            Console.WriteLine("\tcamera");


        }
        public override void music()
        {
            Console.WriteLine("\tmusic");
            Console.WriteLine("Repairing...");
            Console.WriteLine("\n");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            samsung_phone s1 = new samsung_phone();
            oppo_phone o1 = new oppo_phone();
            repair rs = new repair();
            rs.Phone_repair(s1);
            rs.Phone_repair(o1);
            Console.ReadKey();
        }
    }
}
