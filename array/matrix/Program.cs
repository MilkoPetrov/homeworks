using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number for a ");
            int a = int.Parse(Console.ReadLine());
            int[,] b = new int[a, a];
            int c = 1;

            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = c;
                    c++;

                }
            }
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
