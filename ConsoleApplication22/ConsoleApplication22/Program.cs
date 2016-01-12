using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 5, 7, 9, 40, 60 };
            int sum = 0;
            Console.WriteLine("output:");
            for (int i = 0; i < array.Length; i++)
            {
               

                if (array[i] % 2 == 0)
                {

                    sum += array[i];
                }
            }
            Console.WriteLine(sum);
                                }
    }
}
