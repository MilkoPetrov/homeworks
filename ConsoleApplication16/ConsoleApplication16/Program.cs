using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a integer:");

            int numInt = int.Parse(Console.ReadLine());
            if (numInt > 0 && numInt < 6)
            {
                if (numInt % 2 == 0)
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    Console.WriteLine("Ok is not Ok");
                }
            }
            else if (numInt > 5 && numInt < 16)
            {
                if (numInt %3 == 0 )
                {
                    Console.WriteLine("its good");
                }
                else
                {
                    Console.WriteLine("It`s not good");
                }
            }
            else
            {
                if (numInt > 0)
                {
                    Console.WriteLine("Possitve");
                }
                else if (numInt < 0)
                {
                    Console.WriteLine("Negative");
                }
                else
                {
                    Console.WriteLine("0");
                }
            }

        



        }
    }
}
