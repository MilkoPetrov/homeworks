using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[10];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = i * 10;

            }
            Console.WriteLine(string.Join(",", mass));


        }
    }
}
