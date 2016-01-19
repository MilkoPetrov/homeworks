using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_less_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number for a ");
         int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter mumber b biger then a" );
         int b = int.Parse(Console.ReadLine());

            for (; a < b; a++)
            {
                if (a %3 ==0)
                {
                    Console.WriteLine(a);
                }
            }
        }
    }
}
