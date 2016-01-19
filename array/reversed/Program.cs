using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversed
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 30;
            int c = 0;
            int r = 0;

            int[,] mass = new int[5, 6];
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
            }

            while (number >= 1 )
            {
                if (c == mass.GetLength(1))
                {
                    c = 0;
                    r++;
                    Console.WriteLine();
                }

                Console.Write(" {0} ", number);

                mass[r,c] = number;
                number--;
                c++;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        
    }
}
