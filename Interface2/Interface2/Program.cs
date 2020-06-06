using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    class Program
    {
        static void Main(string[] args)
        {
            square sq = new square();
            star st = new star();

            string s1 = st.PendantMaking();
            string s2 = sq.PendantMaking();

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.ReadKey();
        }
    }
}
