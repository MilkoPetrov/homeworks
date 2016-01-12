using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 2;

            while (counter <= 20)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine(counter);
                }
                counter++;
            
            }
        }
    }
}