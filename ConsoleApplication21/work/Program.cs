using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                int i = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    break;

                    sum += i;
                    Console.WriteLine(sum);


                }

            }
        }

    }
}
