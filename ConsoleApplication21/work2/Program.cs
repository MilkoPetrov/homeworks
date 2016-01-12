using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] brr = new int[size];
            for (int i = 0; i < brr.Length; i++)

            {
                brr[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in brr)
            {
                Console.WriteLine(item);
            }
        

        }
    }
}
