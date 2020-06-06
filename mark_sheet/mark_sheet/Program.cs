using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mark_sheet
{
    class marksheet
    {

        public int roll, total, sub1, sub2, sub3, sub4, sub5, sub6;
        public float percentage ;
        public string name;
        public float Result(int roll, int total, int sub1, int sub2, int sub3, int sub4, int sub5, int sub6, string name)
        {
            Console.WriteLine("\t\t********** MARKSHEET OF STUDENT FOR FIVE SUBJECTS **********");
            Console.Write("\t\nEnter Roll Number : ");
            roll = int.Parse(Console.ReadLine());
            Console.WriteLine("****************************************** ");
            Console.Write("\t\nEnter Student's Name : ");
            name = Console.ReadLine();
            Console.WriteLine("****************************************** ");
            Console.Write("\tEnter marks of OOP : ");
            sub1 = int.Parse(Console.ReadLine());
            Console.WriteLine("****************************************** ");
            Console.Write("\tEnter marks of Calculas : ");
            sub2 = int.Parse(Console.ReadLine());
            Console.WriteLine("****************************************** ");
            Console.Write("\tEnter marks of Linear Algebra : ");
            sub3 = int.Parse(Console.ReadLine());
            Console.WriteLine("****************************************** ");
            Console.Write("\tEnter marks of BCS : ");
            sub4 = int.Parse(Console.ReadLine());
            Console.WriteLine("****************************************** ");
            Console.Write("\tEnter marks of Urdu : ");
            sub5 = int.Parse(Console.ReadLine());
            Console.WriteLine("****************************************** ");
            Console.Write("\tEnter marks of Pak-Studies : ");
            sub6 = int.Parse(Console.ReadLine());
            Console.WriteLine("****************************************** ");
            total = sub1 + sub2 + sub3 + sub4 + sub5 + sub6;
            percentage = total / 6.0f;
            Console.WriteLine("\tTotal marks is : {0}", total);
            Console.WriteLine("****************************************** ");
            Console.WriteLine("\tPercentage is : {0}", percentage);
            Console.WriteLine("****************************************** ");

            return percentage;

            /*if (percentage >= 85 && percentage < 100)
            {
                Console.WriteLine("Grade is A+");
            }
            if (percentage >= 70 && percentage < 85)
            {
                Console.WriteLine("\tGrade is A");
            }
            if (percentage >= 60 && percentage < 70)
            {
                Console.WriteLine("\tGrade is B");
            }
            if (percentage >= 50 && percentage < 60)
            {
                Console.WriteLine("\tGrade is C");
            }
            if (percentage < 50)
            {
                Console.WriteLine("\tGrade is D");
            }
            if (percentage > 100)
            {
                Console.WriteLine("\tINVALID INPUT");
            }*/
            
        }
            
    }
    class Program
    {
        static void Main(string[] args)
        {
            marksheet a = new marksheet();
            Console.WriteLine(a.Result(11,150,20,20,20,20,20,20,"rafay"));
            

            

            Console.WriteLine();

            Console.ReadLine();
            Console.ReadKey();

        }
    }
}
