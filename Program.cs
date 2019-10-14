using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number : ");
            int a = 0;
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine(a + " is an Even number.");
            }
            else
            {
                Console.WriteLine(a + " is a Odd number.");
            }


            Console.ReadLine();

        }
    }
}
